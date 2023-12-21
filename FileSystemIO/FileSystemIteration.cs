using VAdvanceStringLibrary.Services.Internals.Arrays;

namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Performs file system collection operations.
	/// </summary>
	public class FileSystemIteration
	{

		private static SemaphoreSlim s_semaphore=new SemaphoreSlim(Environment.ProcessorCount);

		private string[] _buffer;



		/// <summary>
		/// Gets all directories recursively.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public async Task<string[]> GetAllDirectories(string path)
		{
			var res=await Prv_GetAllDirectories(path);
			Array.Clear(_buffer);
			return res;
		}

		private async Task<string[]> Prv_GetAllDirectories(string path)
		{
			string[] dirs=path.GetDirectories();
			string[] res=dirs;
			List<Task> taskList=new ();
			foreach(var sel in dirs)
			{
				if(sel.HasAccess())
				{
					await s_semaphore.WaitAsync();
					var task=Task.Run(new Action(async ()=>
					{
						_buffer=_buffer.Merge(await GetAllDirectories(sel));
						s_semaphore.Release();
					}));
				}
			}
			await Task.WhenAll(taskList);
			res=res.Merge(_buffer);
			return res;
		}

		/// <summary>
		/// Gets all files recursively.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public async Task<string[]> GetAllFiles(string path)
		{
			var res=await Prv_GetAllFiles(path);
			Array.Clear(_buffer);
			return res;
		}

		private async Task<string[]> Prv_GetAllFiles(string path)
		{
			string[] res=path.GetFiles();
			List<Task> taskList=new ();
			foreach(var sel in path.GetDirectories())
			{
				if(sel.HasAccess())
				{
					await s_semaphore.WaitAsync();
					var task=Task.Run(new Action(async ()=>
					{
						_buffer=_buffer.Merge(await GetAllFiles(sel));
						s_semaphore.Release();
					}));
				}
			}
			await Task.WhenAll(taskList);
			res=res.Merge(_buffer);
			return res;
		}

	}
}
