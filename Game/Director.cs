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
        private bool playAgain = true;
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
            while (playAgain)
            {
                _word.PickWord();
                while (!isDone)
                {
                    GetInputs();
                    DoUpdates();
                    DoOutputs();
                }
            }
        }

        /// <summary>
        /// gathers inputs from the user
        /// </summary>
        private void GetInputs()
        {
            bool canGuess = true;
            while (canGuess)
            {
                string playerGuess = _terminal.ReadText("Guess a letter [a-z]: ");
                if (guesses.Contains(playerGuess))
                {
                    _terminal.WriteText($"{playerGuess} has already been guessed. Please try again.");
                }
                else
                {
                    guesses.Add(playerGuess.ToLower());
                    canGuess = false;
                }
            }
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
                _terminal.WriteText("YOU DIED!");
                string newWord = _word.GetNewWord();
                _terminal.WriteText($"The word was {newWord}");
                playAgain = _jumper.PlayAgain();
            }
            else if (finishedWord)
            {
                isDone = true;
                _terminal.ReadText("YOU WIN!");
                playAgain = _jumper.PlayAgain();
            }
        }
    }
}