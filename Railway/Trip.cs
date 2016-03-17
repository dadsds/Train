using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    public class Trip
    {
        private List<Train> trains = new List<Train>();

        public Trip(int number, string from, string to, Train[] t)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                throw new ArgumentException("Incoming or departure of trip can't be empty");
            }

            if (t == null || t.Count() == 0)
            {
                throw new ArgumentException("Count of trains is invalid");
            }

            trains.AddRange(t);

            Number = number;
            From = from;
            To = to;
        }

        public Train[] Trains
        {
            get { return trains.ToArray(); }
        }

        public int Number { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public override string ToString()
        {
            return $@"Number: {Number}; From: {From}; To: {To}";
        }
    }
}
