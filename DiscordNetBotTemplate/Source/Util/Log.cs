using System;
using System.Globalization;
using System.Resources;

namespace MaxPlayle.DiscordNetBotTemplate.Source.Util
{
    internal class Log
    {
        public static void Info(string log)
        {
            var c = CurrentColor;
            c = ConsoleColor.White;
            Console.WriteLine(log);
            CurrentColor = c;
        }

        public static void Warn(string log)
        {
            var c = CurrentColor;
            CurrentColor = ConsoleColor.Yellow;
            Console.WriteLine(log);
            CurrentColor = c;
        }

        public static void Error(string log)
        {
            var c = CurrentColor;
            CurrentColor = ConsoleColor.Red;
            Console.WriteLine(log);
            CurrentColor = c;
        }

        public static void Error(Exception e)
        {
            var c = CurrentColor;
            CurrentColor = ConsoleColor.Red;
            Console.WriteLine("------------------------ ERROR ------------------------");
            Console.WriteLine("Type: ", e.GetType().Name);
            Console.WriteLine("Stack: ", e.StackTrace);
            Console.WriteLine("Message: ", e.Message);
            Console.WriteLine("-------------------------------------------------------");
            CurrentColor = c;
        }
        
        
        /// <summary>
        /// Get/set the current console colour.
        /// </summary>
        private static ConsoleColor CurrentColor
        {
            get => Console.ForegroundColor;
            set => Console.ForegroundColor = value;
        }
        
    }
}