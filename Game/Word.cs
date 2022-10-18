using System;


namespace JumperGame
{
    internal class Word
    {
        new TerminalService terminal = new TerminalService();
        private List<string> wordList = new List<string>();
        
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
        public void PickWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(wordList.Count);
            string newWord = wordList[index];
        }

        /// <summary>
        /// Prints the guess with _ representing letters not yet guessed
        /// </summary>
        public void PrintWord(string guessWord, List<char> correctGuesses)
        {
            List<string> printedWord = new List<string>();
            foreach (char i in guessWord)
            {
                string letter = i.ToString();
                if (newWord.Contains(letter))
                {
                    printedWord.Append(letter);
                }
                else
                {
                    printedWord.Append("_");
                }
            }
            string outputWord = String.Join(" ", printedWord);
            terminal.ReadText(outputWord);
        }
    }
}