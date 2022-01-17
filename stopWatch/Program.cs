using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchExercise // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true) {
                Console.Write("##### To start and stop the stopwatch, simply type \"start\" to start and \"stop\" to stop and then press enter ##### \n: ");
                var consoleInupt = Console.ReadLine();

                if (consoleInupt == "start" || consoleInupt == "stop") 
                {
                    var stopWatch = new StopWatch();
                    if (consoleInupt == "start") 
                    {
                        stopWatch.StartTimer(DateTime.Now);
                    }
                    if (consoleInupt == "stop") 
                    {
                        stopWatch.StopTimer(DateTime.Now);

                        System.Console.WriteLine("The duration was: " + stopWatch.Duration());
                    }

                }
                if (consoleInupt == "exit" || consoleInupt == "quit")
                {
                    System.Console.WriteLine("Exiting application...");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid input...READ THE INSTRUCTIONS YOU FUCKING CUNT!"); 
                }
            }
        }
    }
}
