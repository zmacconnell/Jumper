using System;


namespace JumperGame
{
    internal class Word
    {
        new TerminalService terminal = new TerminalService();
        private List<string> wordList = new List<string>();
        public int _incorrectGuesses = 0;
        
        private string newWord = "";
        public Word()
        {
            wordList.Add("septuagenarian");
            wordList.Add("implacable");
            wordList.Add("computer");
            wordList.Add("orangutang");
            wordList.Add("slime");
            wordList.Add("catholic");
            wordList.Add("crankshaft");
            wordList.Add("carburator");
            wordList.Add("exhaust gas recirculation");
        }
        /// <summary>
        /// Randomly picks a word from a private list of words
        /// </summary>
        public void PickWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(wordList.Count);
            newWord = wordList[index];
        }

        /// <summary>
        /// Prints the guess with _ representing letters not yet guessed
        /// </summary>
        public int PrintWord(List<string> guesses)
        {
            List<string> printedWord = new List<string>();
            foreach (char i in newWord)
            {
                string letter = i.ToString();
                if (guesses.Contains(letter))
                {
                    printedWord.Append(letter);
                }
                else
                {
                    printedWord.Append("_");
                }
            }
            string outputWord = String.Join(" ", printedWord);
            terminal.WriteText(outputWord);
            foreach (string i in guesses)
            {
                if (!newWord.Contains(i))
                {
                    _incorrectGuesses += 1;
                }
            }
            return _incorrectGuesses;
        }
    }
}