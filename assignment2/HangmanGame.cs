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
			foreach(char c in secretWord)
			{
				if (c == letter)
				{
					return true;
				}

			}
			return false;
		}


		public void ProcessLetter(char letter)
		{
			string placeholderWord = null;
			for (int i = 0; i < secretWord.Length - 1 ; i++)
			{
				if (secretWord[i] == letter)
				{
					placeholderWord += secretWord[i];
				}

				else
				{
					placeholderWord += guessedWord[i];
				}
			}

			 guessedWord = placeholderWord;
		}

		public bool isGuessed()
		{
			if(secretWord == guessedWord)
			{
				return true;
			}
			return false;


		}

	}


}

