using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    public struct Seat
    {
        private int ticketNumber;

        private bool isBooked;

        public int TicketNumber
        {
            get { return ticketNumber; }
        }

        public bool IsBooked
        {
            get { return isBooked; }
        }

        public void BookSeat(int ticketNumber)
        {
            isBooked = true;
            this.ticketNumber = ticketNumber;
        }

        public void UnbookSeat()
        {
            isBooked = false;
            ticketNumber = 0;
        }

        public override string ToString()
        {
            return $@"Ticket number : {TicketNumber}; Booked: {isBooked}";
        }
    }
}
