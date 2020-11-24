using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class MusicalTicket : Ticket
    {
        private string composer;

        public MusicalTicket(decimal pr, string ttl, string dt, string time, string loc, string cName, string cmpr)
            : base(pr, ttl, dt, time, loc, cName)
        {
            composer = cmpr;
        }

        public override string ToString()
        {
            return $"Event:\t\t{title}" +
                $"\nMusic by:\t\t{composer}" +
                $"\nDate:\t\t{date}" +
                $"\nStart Time:\t\t{startTime}" +
                $"\nVenue:\t\t{location}" +
                $"\nTicket Price:\t\t{price.ToString("c")}" +
                $"\n" +
                $"\nIssued for:\t\t{clientName}";
        }
    }
}
