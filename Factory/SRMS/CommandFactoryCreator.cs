using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SRMS
{
    internal abstract class CommandFactoryCreator
    {
        internal abstract Command CreateCommand(string commandType);
    }
}
