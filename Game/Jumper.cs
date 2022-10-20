using System;


namespace JumperGame
{
    internal class Jumper
    {
        new TerminalService _terminal = new TerminalService();
        public bool _isDead = false;
        private Word _word = new Word();
        public List<string> parachuteMan = new List<string>();
        private string wholeMan = "";

        /// <summary>
        /// Construct a new instance of Jumper
        /// </summary>
        public Jumper()
        {
            parachuteMan.Add(@"  ___  ");
            parachuteMan.Add(@" /___\ ");
            parachuteMan.Add(@" \   / ");
            parachuteMan.Add(@"  \ /  ");
            parachuteMan.Add(@"   O   ");
            parachuteMan.Add(@"  /|\  ");
            parachuteMan.Add(@"  / \  ");
            parachuteMan.Add(@"^^^^^^^");
            string wholeMan = String.Join("\n", parachuteMan);
        }

        /// <summary>
        /// Prints out the Jumper
        /// </summary>
        public void PrintJumper()
        {
            _terminal.WriteText(wholeMan);
        }
    }
}