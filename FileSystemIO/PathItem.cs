namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Stores path information.
	/// </summary>
	/// <remarks>
	/// Creates a new instance of the <see cref="PathItem"/> struct.
	/// </remarks>
	/// <param name="path"></param>
	public class PathItem(string path)
	{
		/// <summary>
		/// The path value stored from initialization of this object.
		/// </summary>
		private readonly string PathValue = path;
		/// <summary>
		/// Indicates if this path is currently selected through iteration.
		/// </summary>
		public bool Selected { get; set; } = false;
		/// <summary>
		/// The name of the given path.
		/// </summary>
		public string Name => Path.GetFileName(PathValue);
		/// <summary>
		/// Gets the file extension as all lowercase characters, or "DIRECTORY" if the path references a directory.
		/// </summary>
		public string Type => Path.HasExtension(PathValue) ? Path.GetExtension(PathValue).ToLower() : "DIRECTORY";
		/// <summary>
		/// The size of the file represented as <see cref="long"/>.
		/// </summary>
		public long DataSize => IsFile ? PathValue.GetFileSize() : -1;
		/// <summary>
		/// The human-readable data-size of the file represented as a <see cref="string"/>.
		/// </summary>
		public string Size => IsFile ? PathValue.GetFileSizeString() : "";
		/// <summary>
		/// Determines if the given path is a file or directory.
		/// </summary>
		public bool IsFile => PathValue.IsFile();
		/// <summary>
		/// Gets the timestamp of when the file or directory was created.
		/// </summary>
		public DateTime Created => IsFile ? File.GetCreationTime(PathValue) : Directory.GetCreationTime(PathValue);
		/// <summary>
		/// Gets the timestamp of when the file or directory was last modified.
		/// </summary>
		public DateTime Modified => IsFile ? File.GetLastWriteTime(PathValue) : Directory.GetLastWriteTime(PathValue);
		/// <summary>
		/// Gets the timestamp of when the file or directory was last accessed.
		/// </summary>
		public DateTime Accessed => IsFile ? File.GetLastAccessTime(PathValue) : Directory.GetLastAccessTime(PathValue);
	}
}
