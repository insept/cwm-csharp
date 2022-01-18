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
                

                
                    Console.Write("##### To start and stop the stopwatch, simply type \"start\" to start and \"stop\" to stop and then press enter ##### \n: ");
                    var consoleInupt = Console.ReadLine();
                    var stopWatch = new StopWatch();
                    if (consoleInupt != "start" || consoleInupt != "stop" || consoleInupt != "exit" || consoleInupt != "quit" || consoleInupt != "q")
                    {
                        System.Console.WriteLine("***** You have entered an !! invalid input value, please try again. *****\n");
                    }
                    else
                    {
                        if (var consoleInupt == "start") 
                        {
                        startOver = false;
                        stopWatch.StartTimer(DateTime.Now.TimeOfDay);
                        System.Console.WriteLine("You've started the stopwatc!\n, type \"stop\" to stop it or \"quit\" to quit out of the application\n: ");
                        var stopOrExit = System.Console.Read();
                            
                        if (consoleInupt == "stop") 
                        {
                            stopWatch.StopTimer(DateTime.Now.TimeOfDay);
                                
                            var seconds = stopWatch.StopTime.Seconds - stopWatch.StartTime.Seconds;
                            var minutes = stopWatch.StopTime.Minutes - stopWatch.StartTime.Minutes;
                            var hours = stopWatch.StopTime.Hours - stopWatch.StartTime.Hours;
                            System.Console.WriteLine("The total duration was (HH/MM/SS): " + hours + ":" + minutes + ":" + seconds);
                            System.Console.WriteLine("WOW! That was fun! Do you want to try it again? Y/N: ");
                            var consoleInput = System.Console.ReadLine();
                            if (consoleInput != "Y" || consoleInput != "y" || consoleInput != "N" || consoleInput != "n" || consoleInput != "Yes" || consoleInput != "yes" || consoleInput != "No" || consoleInput != "no")
                            {
                                System.Console.WriteLine("***** You have entered an invalid input value, please try again. *****\n");     
                                continue;                           
                            }
                            if (consoleInput == "N" || consoleInput != "n" || consoleInput == "No" || consoleInput == "no" )
                            {
                                System.Console.WriteLine("Closing application...!!!!!!!!!!!1111one");
                                break;    
                            }
                        }
                    }
                }
            }
        }
    }    