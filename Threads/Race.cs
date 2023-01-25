using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Race
    {
        public string CarName { get; set; }
        public int CarKM { get; set; } = 0;
        private int SleepTime { get; set; } = 500;
        private bool StopLoop { get; set; } = false;

        public Race(string carName)
        {
            CarName = carName;
            Task.Run(Drive);
        }

        public string Drive()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomKM;
            while (!StopLoop)
            {               
                randomKM = random.Next(101);
                CarKM = CarKM + randomKM;
                Console.WriteLine($"The car {CarName} has driven: {randomKM}KM (In total {CarKM}KM)");
                if (CarKM > 10000) StopLoop = true;

                Thread.Sleep(SleepTime + randomKM);
            }

            return CarName;
        }
    }
}
