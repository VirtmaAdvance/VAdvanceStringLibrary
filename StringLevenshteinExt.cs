﻿using VAdvanceStringLibrary.Services.Internals.Arrays;

namespace VAdvanceStringLibrary
{
	/// <summary>
	/// Provides extension methods to perform Levenshtein operations for the string class.
	/// </summary>
	public static class StringLevenshteinExt
	{

		/// <summary>
		/// Calculates the levenshtein distance between the base string value and the provided string value.
		/// </summary>
		/// <param name="str">The base string value which is obtained automatically by the string itself.</param>
		/// <param name="value">The string value to match the base string value against.</param>
		/// <param name="insertion_cost">The cost to insert a new character.</param>
		/// <param name="replacement_cost">The cost to replace an existing character.</param>
		/// <param name="deletion_cost">The cost to delete an existing character.</param>
		/// <returns>a <see cref="int">value</see> representing the total cost calculated.</returns>
		public static int Levenshtein(this string str, string value, int insertion_cost = 1, int replacement_cost = 1, int deletion_cost = 1)
		{
			if(value.IsValid(str))
			{
				int res=str[0]!=value[0] ? 1 : 0;
				return Prv_LevenshteinIteration(str, value, replacement_cost, insertion_cost, deletion_cost, res) + (deletion_cost*GetValueLengthDifference(str, value));
			}
			return -1;
		}
		/// <summary>
		/// Performs an iteration for the Levenshtein operation.
		/// </summary>
		/// <param name="str">The <see cref="string"/> value to process.</param>
		/// <param name="value">The value to process.</param>
		/// <param name="replacement_cost">The cost value for replacement.</param>
		/// <param name="insertion_cost">The insertion cost.</param>
		/// <param name="deletion_cost">The deletion cost.</param>
		/// <param name="res">The result.</param>
		/// <returns>the costs made for each change detected as an <see cref="int"/>.</returns>
		private static int Prv_LevenshteinIteration(string str, string value, int replacement_cost, int insertion_cost, int deletion_cost, int res)
		{

			int char_length=Math.Min(str.Length,value.Length);
			int[] character_indexes=GetCharacterIndexes(str,value,char_length);
			foreach(int i in character_indexes)
				if(i>0 && i<char_length && value[i]!=str[i])
					res=Prv_LevenshteinOp(str, value, i, replacement_cost, insertion_cost, deletion_cost);
			return res;
		}

		private static int Prv_LevenshteinOp(string str, string value, int i, int replacement_cost, int insertion_cost, int deletion_cost) => value[i-1]==str[i-1] && value[i+1]==str[i+1] ? replacement_cost : value[i-1]==str[i-1] && value[i]==str[i+1] ? insertion_cost : deletion_cost;
		/// <summary>
		/// Gets the length different between two string values.
		/// </summary>
		/// <param name="first_value"></param>
		/// <param name="second_value"></param>
		/// <returns>a <see cref="int">value</see> representing the difference between the two string values.</returns>
		private static int GetValueLengthDifference(string first_value, string second_value) => first_value.Length>second_value.Length ? first_value.Length-second_value.Length : second_value.Length-first_value.Length;
		/// <summary>
		/// Gets all indexes where the two string values do not match.
		/// </summary>
		/// <param name="first_value"></param>
		/// <param name="second_value"></param>
		/// <param name="max_length"></param>
		/// <returns>a <see cref="List{Int}"/></returns>
		private static int[] GetCharacterIndexes(string first_value, string second_value, int max_length)
		{
			int[] character_indexes={ };
			for(int i = 0;i<max_length;i++)
				if(first_value[i]!=second_value[i])
					character_indexes=character_indexes.Push(i);
			return character_indexes;
		}

	}
}