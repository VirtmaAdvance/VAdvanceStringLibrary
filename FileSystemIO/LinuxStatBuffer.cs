using System.Runtime.InteropServices;

namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Provides a data struct object for Linux file information.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct LinuxStatBuffer
	{
		public ulong st_dev;
        public ulong st_ino;
        public uint st_mode;
        public uint st_nlink;
        public uint st_uid;
        public uint st_gid;
        public ulong st_rdev;
        public long st_size;
        public long st_blksize;
        public long st_blocks;
        public long st_atime;
        public long st_atime_nsec;
        public long st_mtime;
        public long st_mtime_nsec;
        public long st_ctime;
        public long st_ctime_nsec;
        public long unused1;
        public long unused2;
	}
}
