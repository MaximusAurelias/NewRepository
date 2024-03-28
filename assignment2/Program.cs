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
        hangman.Init("Albequrque");

        Console.WriteLine($"The secret word is: {hangman.secretWord}");
        Console.WriteLine($"The guessed word is: {hangman.guessedWord}");


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


    bool PlayHangman(HangmanGame hangman)
    {
        List<char> enteredLetters = new List<char>();


        DisplayWord(hangman.GetGuessedWord());

        DisplayLetters(enteredLetters);


        char letter = ReadLetter(enteredLetters);
        enteredLetters.Add(letter);


        if (hangman.ContainsLetter(letter))
        {
            hangman.ProcessLetter(letter);
        }

        return true;

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
        } while (blacklistLetters.Contains(letter));

        return letter;
    }

}
