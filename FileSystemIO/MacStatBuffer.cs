using System.Runtime.InteropServices;

namespace VAdvanceStringLibrary.FileSystemIO
{
	/// <summary>
	/// Provides a data struct object for Linux file information.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct MacStatBuffer
	{
		public uint st_dev;
        public ushort st_mode;
        public ushort st_nlink;
        public uint st_ino;
        public uint st_uid;
        public uint st_gid;
        public uint st_rdev;
        public long st_size;
        public long st_atime;
        public long st_atime_nsec;
        public long st_mtime;
        public long st_mtime_nsec;
        public long st_ctime;
        public long st_ctime_nsec;
        public long st_birthtime;
        public long st_birthtime_nsec;
        public long st_flags;
        public long st_gen;
        public long st_lspare;
        public long st_qspare1;
        public long st_qspare2;
	}
}