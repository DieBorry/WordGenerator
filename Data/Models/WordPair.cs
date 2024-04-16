namespace WordGenerator.Data.Models
{
	internal class WordPair
	{
		public string FullWord { get { return FirstHalf + LastHalf; } }

		public string FirstHalf { get; set; }
		public string LastHalf { get; set; }

		public WordPair(string firstHalf, string lastHalf)
		{
			FirstHalf = firstHalf;
			LastHalf = lastHalf;
		}
	}
}
