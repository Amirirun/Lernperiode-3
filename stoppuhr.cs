using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleStoppuhr
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); // Stoppuhr initialisieren
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Stoppuhr");
                Console.WriteLine("---------");
                Console.WriteLine($"Verstrichene Zeit: {stopwatch.Elapsed:hh\\:mm\\:ss}");
                Console.WriteLine("Optionen:");
                Console.WriteLine("[1] Start");
                Console.WriteLine("[2] Stop");
                Console.WriteLine("[3] Reset");
                Console.WriteLine("[4] Exit");
                Console.Write("Wähle eine Option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": // Start
                        if (!stopwatch.IsRunning)
                        {
                            stopwatch.Start();
                        }
                        break;
                    case "2": // Stop
                        if (stopwatch.IsRunning)
                        {
                            stopwatch.Stop();
                        }
                        break;
                    case "3": // Reset
                        stopwatch.Reset();
                        break;
                    case "4": // Exit
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Drücke eine Taste, um fortzufahren.");
                        Console.ReadKey();
                        break;
                }

                // Kurze Pause für Echtzeit-Aktualisierung der Anzeige
                if (running)
                {
                    Thread.Sleep(200);
                }
            }

            Console.WriteLine("Programm beendet.");
        }
    }
}
