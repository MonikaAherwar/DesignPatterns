using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SRMS
{
    internal class CommandFactoryLocal : CommandFactoryCreator
    {
        internal override Command CreateCommand(string commandType)
        {
            Command command = null;
            if (commandType == "Powershell")
                command = new PowershellCommand();
            else if(commandType == "Console")
                command = new ConsoleCommand();
            else if (commandType == "SQL")
                command = new SQLCommand();
            else if (commandType == "Notepad")
                command = new NotepadCommand();

            if (command == null)
                throw new Exception("Invalid Command Type");

            return command;
        }
    }
}
