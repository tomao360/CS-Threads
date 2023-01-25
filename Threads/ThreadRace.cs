using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class ThreadRace
    {
        Race[] Cars;
        List<string> RaceResults;
        List<string> CarNames;

        public ThreadRace()
        {
            Cars = new Race[10];
            RaceResults = new List<string>();
            CarNames = new List<string>();
            Init();
        }
        public void NameList()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a car name:");
                CarNames.Add(Console.ReadLine());
                Console.WriteLine("\n");
            }
        }
        public void Init()
        {
            NameList();
            if (CarNames.Count > 0)
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    Cars[i] = new Race(CarNames[i]);
                }
            }
        }

        public void MainLoop()
        {
            int i = 1;
            if (Cars[Cars.Length - 1] != null)
            {
                while (RaceResults.Count < 3)
                {
                    RaceResults.Add(Cars[i].Drive());
                    if (RaceResults.Count != 0)
                    {
                        Console.WriteLine("*****************************************");
                        Console.WriteLine($"****In the {i} place won: car {RaceResults.Last<string>()}*****");
                        Console.WriteLine("*****************************************");
                    }

                    i++;
                }
            }
        }
    }
}
