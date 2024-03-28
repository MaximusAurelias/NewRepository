using System;
namespace assignment2
{
	public class HangmanGame
	{
		public string secretWord;
		public string guessedWord;


		public void Init(string secretWord)
		{

			this.secretWord = secretWord;
			foreach (char c in secretWord)
			{
				guessedWord = guessedWord + ".";
			}
		}


		public bool ContainsLetter(char letter)
		{
			return secretWord.Contains(letter);
		}

		public void ProcessLetter(char letter)
		{
			string placeholderWord = null;
			for (int i = 0; i < secretWord.Length; i++)
			{
				if (secretWord[i] == letter)
				{
					placeholderWord += secretWord[i];
				}

				else
				{
					secretWord += guessedWord[i];
				}
			}
		}

	}


}

