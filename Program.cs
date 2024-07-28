using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    public static class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            if (command is "--help")
            {

            }
            else
            {
                Console.WriteLine("Usage: convert.exe input.wav output.mp3");
            }

            Console.ReadKey(true);
        }
        private static string GetCommand()
        {
            string output = Environment.CommandLine;
            int firstArgumentEnd = -1;
            bool inQuotes = false;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] is '\"')
                {
                    inQuotes = !inQuotes;
                }
                else if (output[i] is ' ' && !inQuotes)
                {
                    firstArgumentEnd = i;
                    break;
                }
            }

            if (!(firstArgumentEnd is -1) && firstArgumentEnd + 1 < output.Length)
            {
                return output.Substring(firstArgumentEnd + 1);
            }
            else
            {
                return "";
            }
        }
    }
}
