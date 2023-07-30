using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SRMS
{
    internal class CommandFactoryProduction : CommandFactoryCreator
    {
        internal override Command CreateCommand(string commandType)
        {
            Command command = null;
            if (commandType == "Powershell")
                command = new PowershellCommand();
            else if (commandType == "SQL")
                command = new SQLCommand();

            if (command == null)
                throw new Exception("Invalid Command Type");

            return command;
        }
    }
}
