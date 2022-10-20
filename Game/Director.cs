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
        private bool isDead = false;
        private Word _word = new Word();
        private List<string> guesses = new List<string>();
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
            while (!isDead)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            string playerGuess = _terminal.ReadText("Guess a number [a-z]: ");
            guesses.Add(playerGuess.ToLower());
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            _word.PrintWord(guesses);
            _jumper.PrintJumper();
            
            if (_jumper._isDead)
            {
                isDead = true;
            }
            
        }
    }
}