using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SRMS
{
    internal class NotepadCommand : Command
    {
        internal override void Run()
        {
            Console.WriteLine("Running Command: Notepad Command");
        }
    }
}
