using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SRMS
{
    internal class Runbook
    {
        internal List<string> commands;

        internal Runbook(bool isProduction)
        {
            commands = new List<string>();

            commands.Add("SQL");
            commands.Add("Powershell");

            if (!isProduction)
            {
                commands.Add("Console");
                commands.Add("Notepad");
            }
        }
    }
}
