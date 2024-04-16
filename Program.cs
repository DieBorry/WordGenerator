using WordGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace WordGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{

			string filePath = "..\\..\\..\\Data\\input.txt";
			HashSet<string> data = new HashSet<string>(File.ReadAllLines(filePath));
			List<string> fullWords = new List<string>();
			List<string> halves = new List<string>();
			List<WordPair> wordPairs = new List<WordPair>();

			foreach (string word in data)
			{
				string trimmedWord = word.Trim();
				if (trimmedWord.Length < 6)
				{
					halves.Add(trimmedWord);
				}
				else
				{
					fullWords.Add(trimmedWord);
				}
			};
			for (int i = 0; i < halves.Count; i++)
			{
				for (int j = i + 1; j < halves.Count; j++)
				{
					if (fullWords.Contains(halves[i] + halves[j]))
						wordPairs.Add(new WordPair(halves[i], halves[j]));
				}
			}
			foreach (WordPair word in wordPairs.Distinct().ToList())
			{
				Console.WriteLine($"{word.FirstHalf}+{word.LastHalf}={word.FullWord}");
			}

		}
	}
}
