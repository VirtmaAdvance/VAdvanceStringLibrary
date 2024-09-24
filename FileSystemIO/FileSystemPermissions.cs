namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Provides file system permissions flags to represent the permissions of a given file or directory.
	/// </summary>
	[Flags]
	public enum FileSystemPermissions
	{
		/// <summary>
		/// Unknown file permissions.
		/// </summary>
		Unknown=0x0,
		/// <summary>
		/// Allows listing the items within a given directory.
		/// </summary>
		ListDirectory=0x1,
		/// <summary>
		/// Allows for the data to be read from the file.
		/// </summary>
		ReadData=0x1,
		/// <summary>
		/// Allows for files to be created within the specified directory.
		/// </summary>
		CreateFiles=2,
		/// <summary>
		/// Allows data to be written to the file.
		/// </summary>
		WriteData=2,
		/// <summary>
		/// Allows data to be appended to the file.
		/// </summary>
		AppendData=4,
		/// <summary>
		/// Allows for directories to be created within the given directory.
		/// </summary>
		CreateDirectories=4,
		/// <summary>
		/// Allows reading extended attributes from the specified path.
		/// </summary>
		ReadExtendedAttributes=8,
		/// <summary>
		/// Allows writting extended attributes from the specified path.
		/// </summary>
		WriteExtendedAttributes=16,
		/// <summary>
		/// Allows the file to be executed/invoked/ran.
		/// </summary>
		ExecuteFile=32,
		/// <summary>
		/// Allows traversal within the directory.
		/// </summary>
		Traverse=32,
		/// <summary>
		/// Allows deletion of files and subdirectories.
		/// </summary>
		DeleteSubdirectoriesAndFiles=64,
		/// <summary>
		/// Allows reading attributes from the specified file or directory path.
		/// </summary>
		ReadAttributes=128,
		/// <summary>
		/// Allows writting attributes to the specified file or directory path.
		/// </summary>
		WriteAttributes=256,
		/// <summary>
		/// Allows writing to a given file or directory path.
		/// </summary>
		Write=278,
		/// <summary>
		/// Allows the deletion of the given file or directory path.
		/// </summary>
		Delete=65536,
		/// <summary>
		/// Allows reading the permissions of the given file or directory path.
		/// </summary>
		ReadPermissions=131072,
		/// <summary>
		/// Allows reading from the given file or directory path.
		/// </summary>
		Read=131209,
		/// <summary>
		/// Allows reading and execution of a given file path.
		/// </summary>
		ReadAndExecute=131241,
		/// <summary>
		/// Allows modification of a given file or directory path.
		/// </summary>
		Modify=197055,
		/// <summary>
		/// Allows changing the permissions of a given file or directory path.
		/// </summary>
		ChangePermissions=262144,
		/// <summary>
		/// Allows the currently logged in user to take complete ownership of the given file or directory path.
		/// </summary>
		TakeOwnership=524288,
		/// <summary>
		/// Allows synchronization of the file or directory path given.
		/// </summary>
		Synchronize=1048576,
		/// <summary>
		/// Allows full control over a given file or directory path.
		/// </summary>
		FullControl=2032127,
	}
}
