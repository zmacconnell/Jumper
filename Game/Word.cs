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
        
    }
}