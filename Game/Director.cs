namespace JumperGame
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Jumper _jumper = new Jumper();
        private bool isDone = false;
        private Word _word = new Word();
        private List<string> guesses = new List<string>();
        private int incorrectGuesses = 0;
        private bool finishedWord = false;
        private TerminalService _terminal = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            _word.PickWord();
            while (!isDone)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// gathers inputs from the user
        /// </summary>
        private void GetInputs()
        {
            string playerGuess = _terminal.ReadText("Guess a number [a-z]: ");
            guesses.Add(playerGuess.ToLower());
        }

        /// <summary>
        /// Updates game files
        /// </summary>
        private void DoUpdates()
        {
            _word.PrintWord(guesses);
            incorrectGuesses = _word._incorrectGuesses;
            _jumper.JumperState(incorrectGuesses);
            finishedWord = _word._finishedWord;
        }

        /// <summary>
        /// Provides an output
        /// </summary>
        private void DoOutputs()
        {
            if (_jumper._isDead)
            {
                isDone = true;
                _terminal.ReadText("YOU DIED!");
                string newWord = _word.GetNewWord();
                _terminal.WriteText($"The word was {newWord}");
            }
            else if (finishedWord)
            {
                isDone = true;
                _terminal.ReadText("YOU WIN!");
            }
        }
    }
}