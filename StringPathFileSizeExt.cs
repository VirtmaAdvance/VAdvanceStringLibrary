using VAdvanceStringLibrary.FileSystemIO;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides file size information extension methods for the string class.
	/// </summary>
	public static class StringPathFileSizeExt
	{
		/// <summary>
		/// Used for multi-threading...
		/// </summary>
		private static SemaphoreSlim s_semaphore=new(Environment.ProcessorCount);
		/// <summary>
		/// Gets the file size data.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static DataValue GetFileData(this string path) => new (path.GetFileSize());
		/// <summary>
		/// Gets the file size as a simplified string.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string GetFileSizeString(this string path) => path.GetFileData().ToString();
		/// <summary>
		/// Gets all of the directories within a given directory.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static async Task<string[]> GetAllDirectories(string path) => await new FileSystemIteration().GetAllDirectories(path);
		/// <summary>
		/// Gets all of the files within a given directory.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static async Task<string[]> GetAllFiles(string path) => await new FileSystemIteration().GetAllFiles(path);

		/// <summary>
		/// Gets all of the sub-directories within the given <paramref name="path"/>.
		/// </summary>
		/// <param name="path">A <see cref="string"/> representation of an existing file system path.</param>
		/// <returns>a <see cref="string"/> array of the items found.</returns>
		public static string[] GetDirectories(this string path) => path.HasAccess() && path.IsDirectory() ? Directory.GetDirectories(path) : Directory.GetDirectories(Path.GetDirectoryName(Path.GetFullPath(path))!);
		/// <inheritdoc cref="GetDirectories(string)"/>
		/// <summary>
		/// Gets all of the files within the given <paramref name="path"/>.
		/// </summary>
		public static string[] GetFiles(this string path) => path.HasAccess() && path.IsDirectory() ? Directory.GetFiles(path) : Directory.GetDirectories(Path.GetDirectoryName(Path.GetFullPath(path))!);

	}
}
