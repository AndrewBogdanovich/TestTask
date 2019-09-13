using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static string StartTime;
        private static string EndTime;
        static void Main(string[] args)
        {
            //set app start time
            StartTime = DateTime.Now.ToString();
            Console.WriteLine(DateTime.Now);

            DecodingMethod();

            //set app end time
            Console.WriteLine(DateTime.Now);
            EndTime = DateTime.Now.ToString();

            Console.WriteLine($"App start in: {StartTime}, app end in: {EndTime}");
            Console.ReadKey();
        }

        private static void DecodingMethod()
        {
            var stringMessage = GetMessageFromFile();
            var sb = new StringBuilder();

            char[] arraySymbols = stringMessage.ToCharArray();
            var symbolsCount = arraySymbols.Length;

            for (var i = 0; i < symbolsCount; i++)
            {
                if (i < symbolsCount - 1)
                {
                    if (arraySymbols[i] == arraySymbols[i + 1])
                    {
                        arraySymbols[i + 1] = ' ';
                    }
                    else
                    {
                        sb.Append(arraySymbols[i]);
                    }
                }
                else
                {
                    sb.Append(arraySymbols[i]);
                }
            }


            sb.Replace(" ", "");
            Console.WriteLine(sb);
        }

        private static string GetMessageFromFile()
        {
            var filePath = "C:\\Users\\htcon\\source\\repos\\ConsoleApp2\\input\\message.txt";
            string reader = File.ReadAllText(filePath);

            return reader;
        }
    }
}
