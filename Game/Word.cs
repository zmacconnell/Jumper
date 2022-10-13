using System;


namespace JumperGame
{
    internal class Word
    {
        List<string> words = new List<string>();
        public string PickWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);
            string newWord = words[index];
            return newWord;
        }
        public void PrintWord(string guessWord, List<char> correctGuesses);
        {
            foreach (char i in guessWord)
            {
                bool result = guessWord.Contains(i);
                if (result)
                {
                    Console.WriteLine()
                }
            }
        }
    }
}