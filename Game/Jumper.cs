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
        private int _incorrectGuesses = 0;
        public List<string> jumperChute = new List<string>();

        /// <summary>
        /// Construct a new instance of Jumper
        /// </summary>
        public Jumper()
        {
            // parachuteMan.Add(@"  ___  ");
            // parachuteMan.Add(@" /___\ ");
            // parachuteMan.Add(@" \   / ");
            // parachuteMan.Add(@"  \ /  ");
            // parachuteMan.Add(@"   O   ");
            jumperBody.Add(@"  /|\  ");
            jumperBody.Add(@"  / \  ");
            jumperBody.Add(@"^^^^^^^");
            
        }

        /// <summary>
        /// Prints out the Jumper
        /// </summary>
        public void PrintJumper()
        {
            _terminal.WriteText(wholeMan);
        }
        
        public void JumperState(int incorrectGuesses)
        {
            string jumperBodyLine = String.Join("\n", jumperBody);
            _incorrectGuesses = incorrectGuesses;
            if (_incorrectGuesses >= 5)
            {
                _terminal.WriteText(@"   X   ");
                _terminal.WriteText(jumperBodyLine);
                _isDead = true;
            }
            else if (_incorrectGuesses == 4)
            {
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (_incorrectGuesses == 3)
            {
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (_incorrectGuesses == 2)
            {
                _terminal.WriteText(@" \   / ");
                _terminal.WriteText(@"  \ /  ");
                _terminal.WriteText(@"   O   ");
                _terminal.WriteText(jumperBodyLine);
            }
            else if (_incorrectGuesses == 1)
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
    }
}