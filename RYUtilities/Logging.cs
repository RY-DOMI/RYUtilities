using System;
using System.Collections.Generic;
using System.Text;

namespace RYUtilities
{
    public static class Logging
    {
        /// <summary>Writes an information message 
        /// into the console.</summary>
        public static void WriteInfo(string message, bool newLine = true)
        {
            Write("Info", message, ConsoleColor.Cyan, newLine);
        }

        /// <summary>Writes an information message 
        /// into the console.</summary>
        public static void WriteDebug(string message, bool newLine = true)
        {
            Write("Debug", message, ConsoleColor.Yellow, newLine);
        }

        /// <summary>Writes an error message 
        /// into the console.</summary>
        public static void WriteError(string message, bool newLine = true)
        {
            Write("Error", message, ConsoleColor.Red, newLine);
        }

        /// <summary>Writes an message 
        /// into the console.</summary>
        private static void Write(string prefix, string message, ConsoleColor color = ConsoleColor.White, bool newLine = true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(DateTime.Now.ToString("HH:mm:ss"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("/");

            Console.ForegroundColor = color;
            Console.Write(prefix);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("] ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message + (newLine ? "\n" : ""));
            Console.ResetColor();
        }
    }
}
