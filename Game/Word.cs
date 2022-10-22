using System;
using System.IO;


namespace JumperGame
{
    internal class Word
    {
        new TerminalService terminal = new TerminalService();
        private List<string> wordList = new List<string>();
        public int _incorrectGuesses = 0;
        public bool _finishedWord = false;
        
        private string newWord = "";
        public string _path = Directory.GetCurrentDirectory();

        /// <summary>
        /// Creates a new instnace of Word
        /// </summary>
        public Word()
        {
            // wordList.Add("septuagenarian");
            // wordList.Add("implacable");
            // wordList.Add("computer");
            // wordList.Add("orangutang");
            // wordList.Add("slime");
            // wordList.Add("catholic");
            // wordList.Add("crankshaft");
            // wordList.Add("carburator");
            // wordList.Add("exhaust gas recirculation");
            string wordTextFile = _path + @"\Game\WordList.txt";
            List<string> lines = System.IO.File.ReadLines(wordTextFile).ToList();
            foreach (string line in lines)
            {
                wordList.Add(line);
            }
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

        public string GetNewWord()
        {
            return newWord;
        }

        /// <summary>
        /// Prints the guess with _ representing letters not yet guessed
        /// </summary>
        public void PrintWord(List<string> guesses)
        {
            List<string> printedWord = new List<string>();
            int completionTest = 0;
            foreach (char i in newWord)
            {
                string letter = i.ToString();
                if (guesses.Contains(letter))
                {
                    printedWord.Add(letter);
                }
                else
                {
                    printedWord.Add("_");
                    completionTest += 1;
                }
            }
            if (completionTest <= 0)
            {
                _finishedWord = true;
            }
            string outputWord = String.Join(" ", printedWord);
            terminal.WriteText(outputWord);
            _incorrectGuesses = 0;
            List<string> wrongLetters = new List<string>();
            foreach (string i in guesses)
            {
                if (!newWord.Contains(i))
                {
                    _incorrectGuesses += 1;
                    wrongLetters.Add(i);
                }
            }
            string wrongLettersString = String.Join(" ", wrongLetters);
            terminal.WriteText("Incorrect Answers: ");
            terminal.WriteText(wrongLettersString);
        }
    }
}