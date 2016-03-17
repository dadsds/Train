using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    public class Train
    {
        private Seat[] seats;

        public Train(int countOfSeats, DateTime date)
        {
            if (countOfSeats < 0)
            {
                throw new ArgumentException("Count of seats is invalid");
            }

            Date = date;

            seats = new Seat[countOfSeats];
            
        }

        public DateTime Date { get; private set; }

        public Seat[] Seats
        {
            get { return seats; }
        }

        public override string ToString()
        {
            return $@"Date:{Date.ToShortDateString()}; Count of seats: {Seats.Length}";
        }
    }
}
