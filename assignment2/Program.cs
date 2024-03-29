using System;
using System.Net.Sockets;
using System.Numerics;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace assignment2;
class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.Start();
    }

    void Start()
    {
        HangmanGame hangman = new HangmanGame();
        List<string> words = new List<string>();
        words = ListOfWords();
        hangman.Init(SelectWord(words));
        DisplayWord(hangman.guessedWord);
        bool win = PlayHangman(hangman);
        if (win)
        {
            Console.WriteLine("You guessed the word!");
        }
        else
        {
            Console.WriteLine($"Too bad,you did not guess the word ({hangman.secretWord})");
        }

        


    }

    List<string> ListOfWords()
    {

        List<string> wordList = new List<string>
        { "airplane" ,"kitchen" ,"building ","incredible" , "funny" ,

         "trainstation" , "neighbour" ,"different", "department","planet ",
         "presentation", "embarrassment ", "integration",  "scenario",
         "discount","management", "understanding", "registration", "security", "language"};

        return wordList;
    }

    string SelectWord(List<string> words)
    {
        Random rand = new Random();
        return words[rand.Next(0, 20)];
    }

   
        

    bool PlayHangman(HangmanGame hangman)
    {

       
        List<char> enteredLetters = new List<char>();
        bool guessedword = hangman.isGuessed();
        int nrOfAttempts = 8;

        while(nrOfAttempts > 0 && guessedword == false)
        {

            char letter = ReadLetter(enteredLetters);
            enteredLetters.Add(letter);

            Console.Write("Entered Letters: ");
            DisplayLetters(enteredLetters);

            if (hangman.ContainsLetter(letter))
            {
                hangman.ProcessLetter(letter);

            }

            else
            
                nrOfAttempts--;
                Console.WriteLine($"Attempts left:{nrOfAttempts} ");
            

            DisplayWord(hangman.guessedWord);

            if (hangman.isGuessed())
            {
                return true ;
            }
           
        }
        return false;
    }

    void DisplayWord(string word)
    {
        foreach(char letter in word)
        {
            Console.Write(letter + " ");

        }

        Console.WriteLine();
    }

    void DisplayLetters(List<char> letters)
    {

        foreach(char letter in letters)
        {
            Console.Write(letter + " ");
        }
        Console.WriteLine();
    }


    char ReadLetter(List<char> blacklistLetters)
    {
        char letter;
        do
        {
            Console.WriteLine("Enter a letter: ");
            letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
        while (blacklistLetters.Contains(letter));

        return letter;
    }

}
