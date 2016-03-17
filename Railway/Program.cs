using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t1 = new Train(100, DateTime.Now);
            Train t2 = new Train(150, DateTime.Now);
            Train t3 = new Train(80, DateTime.Now);
            Console.WriteLine(t1);
            Trip trip = new Trip(123, "Kiev", "Lviv", new Train[] { t1, t2, t3 });
            Console.WriteLine(trip);

            t1.Seats[1].BookSeat(13);
            Console.WriteLine(t1.Seats[1]);


            Console.ReadKey();
        }
    }
}
