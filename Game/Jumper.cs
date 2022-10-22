using System;


namespace JumperGame
{
    internal class Jumper
    {
        new TerminalService _terminal = new TerminalService();
        public bool _isDead = false;
        private Word _word = new Word();
        private List<string> jumperBody = new List<string>();
        private string wholeMan = "";
        public List<string> jumperChute = new List<string>();

        /// <summary>
        /// Construct a new instance of Jumper
        /// </summary>
        public Jumper()
        {
            jumperBody.Add(@"  /|\  ");
            jumperBody.Add(@"  / \  ");
            jumperBody.Add(@"^^^^^^^");
            
        }

        /// <summary>
        /// Prints out the Jumper
        /// </summary>
        public void JumperState(int incorrectGuesses)
        {
            _terminal.WriteText(wholeMan);
            string jumperBodyLine = String.Join("\n", jumperBody);
            if (incorrectGuesses >= 5)
            {
                _terminal.WriteText(@"   X   ");
                _terminal.WriteText(jumperBodyLine);
                _isDead = true;
            }
            else if (incorrectGuesses == 4)
            {
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (incorrectGuesses == 3)
            {
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (incorrectGuesses == 2)
            {
                _terminal.WriteText(@" \   / ");
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (incorrectGuesses == 1)
            {
                _terminal.WriteText(@" /___\ ");
                _terminal.WriteText(@" \   / ");
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else
            {
                _terminal.WriteText(@"  ___  ");
                _terminal.WriteText(@" /___\ ");
                _terminal.WriteText(@" \   / ");
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);

            }
        }

        public bool PlayAgain()
        {
            bool playAgain = true;
            string playAgainStatus = _terminal.ReadText("Play again (y/n)? ");
            if (playAgainStatus.ToLower() == "y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
            return playAgain;
        }
    }
}