using System;


namespace JumperGame
{
    internal class Word
    {
        private List<string> words = new List<string>();
        private string newWord = "";
        public void PickWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);
            string newWord = words[index];
        }

        /// <summary>
        /// Prints the guess with _ representing letters not yet guessed
        /// </summary>
        public void PrintWord(string guessWord, List<char> correctGuesses)
        {
            foreach (char i in guessWord);
            {
                List<string> printedWord = new List<string>();
                string letter = i.ToString();
                if (newWord.Contains(letter);
                {
                    printedWord.Append(letter);
                }
                else
                {
                    printedWord.Append("_");
                }
                string outputWord = String.Join(" ", printedWord);
            }
        }
    }
}