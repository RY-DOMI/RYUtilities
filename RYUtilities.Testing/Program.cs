using System;
using RYUtilities;

namespace RYUtilities.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging.WriteInfo("Loading api...");
            Logging.WriteDebug(">> Starting WEB-Service...");
            Logging.WriteError("Something went wrong!");
        }
    }
}
