using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GuessGameNew
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] GuessWords = {"qyeen", "king", "shoes", "dummy", "instagram", "youtube", "coward", "flooring", "wallpaper", "running", "hookey", "tennis", "episode", "idiots", "lipbalm", "tooth", "professional", "program", "guess", "done", "hand", "care", "mother", "class", "space", "camera", "trollhunter", "parrot", "police", "number", "cream","pineapple", "pizza", "fool", "computer", "book", "drawing", "mouse", 
                "tree", "fan", "horse", "paper", "mice", "door", "television", "troll", "unicorn", "firewolf", "series", "robot",
            "glass", "watermelon", "stupid", "juice", "game", "jerk", "phone", "keyboard", "kingdom", "remote", "wizards", "watch", "hell", "heaven",
            "school", "angel", "alphabet", "wolf", "anger", "favorite", "fashion", "hair", "layer", "lion", "helmet", "curd", "milk",
            "chilli", "danmark", "football", "power"};
            
            bool pass = false;

            Console.Write($"Enter a number between 1 - {GuessWords.Length} \n");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index > 0 && index <= GuessWords.Length)
            {
                string selectedWord = GuessWords[index - 1];
                char[] selectedChar = selectedWord.ToCharArray();

                List<char> guessChar= new List<char>();                

                do
                {
                    string guessResult = "";
                    string result = "";
                    Console.WriteLine("Enter guess, single character");
                    char c = Convert.ToChar(Console.ReadLine());

                    bool match = selectedWord.Contains(c);
                    if (match) guessChar.Add(c);
                    
                    foreach (var ch in selectedChar)
                    {
                        match = false;

                        foreach (var gch in guessChar)
                        {
                           if( ch == gch) match = true;                                   
                        }
                        
                        if(match)
                        {
                            guessResult += ch + " ";
                            result += ch;
                        }
                        else
                        {
                            guessResult += " __ ";
                        }
                    }

                    Console.WriteLine(guessResult);
                    pass = result == selectedWord;
                } while (!pass);

            }
            Console.ReadLine();
        }
    }
}
