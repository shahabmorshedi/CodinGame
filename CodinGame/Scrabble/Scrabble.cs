using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Scrabble
{
	class Scrabble
	{
		private static Dictionary<char, int> scores = new Dictionary<char, int>()
		{
			{ 'a', 1 }, { 'e', 1 }, { 'i', 1 }, { 'l', 1 }, { 'n', 1 }, { 'o', 1 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 },
			{ 'd', 2 }, { 'g', 2 },
			{ 'b', 3 }, { 'c', 3 }, { 'm', 3 }, { 'p', 3 },
			{ 'f', 4 }, { 'h', 4 }, { 'v', 4 }, { 'w', 4 }, { 'y', 4 },
			{ 'k', 5 },
			{ 'j', 8 }, { 'x', 8 },
			{ 'q', 10 }, { 'z', 10 }
		};

		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			List<string> dictionary = new List<string>();

			for (int i = 0; i < N; i++)
			{
				string W = Console.ReadLine();
				dictionary.Add(W.Trim());
			}

			string LETTERS = Console.ReadLine();
            Tuple<int, string> winner = new Tuple<int, string>(0, "");

			for (int i = 0; i < dictionary.Count; i++)
			{
				int score = 0;

				for (int j = 0; j < dictionary[i].Length; j++)
				{
					char L = dictionary[i][j];

					if (!LETTERS.Contains(L))
					{
						score = 0;
						break;
					}

					if (dictionary[i].Substring(0, j).Contains(L))
						break;

					score += scores[L];
				}

                if (score > winner.Item1)
                {
                    winner = new Tuple<int, string>(score, dictionary[i]);
                }
			}
			
			Console.WriteLine("***************");

			Console.WriteLine(winner.Item2);

			Console.ReadLine();
		}
	}
}
