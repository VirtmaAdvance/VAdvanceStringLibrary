namespace VAdvanceStringLibrary
{
	internal static class SoundexReferenceData
	{

		/// <summary>
		/// Ignored characters.
		/// </summary>
		public static readonly string IgnoredRegex="[AEIOUWYHaeiouwyh]+";
		/// <summary>
		/// Ignored characters.
		/// </summary>
		public static readonly string[] Ignored={
			"A","E","I","O","U","W","Y","H"
		};
		/// <summary>
		/// Soundex items.
		/// </summary>
		public static readonly Dictionary<int, string[]> Items=new ()
		{
			{ 1, new string[]{ "B","P","F","V" } },
			{ 2, new string[]{ "C","S","K","G","J","Q","X","Z" } },
			{ 3, new string[]{ "D","T" } },
			{ 4, new string[]{ "L" } },
			{ 5, new string[]{ "M","N" } },
			{ 6, new string[]{ "R" } }
		};
		/// <summary>
		/// Soundex regex items.
		/// </summary>
		public static readonly Dictionary<string,int> ItemsRegex=new ()
		{
			{ "[BPFVbpfv]", 1 },
			{ "[CSKGJQXZcskgjqxz]", 2 },
			{ "[DTdt]", 3 },
			{ "[Ll]", 4 },
			{ "[MNmn]", 5 },
			{ "[Rr]", 6 }
		};
		/// <summary>
		/// Soundex regex chars.
		/// </summary>
		public static readonly Dictionary<string,char> ItemsRegexChar=new()
		{
			{ "[BPFVbpfv]", '1' },
			{ "[CSKGJQXZcskgjqxz]", '2' },
			{ "[DTdt]", '3' },
			{ "[Ll]", '4' },
			{ "[MNmn]", '5' },
			{ "[Rr]", '6' }
		};

	}
}