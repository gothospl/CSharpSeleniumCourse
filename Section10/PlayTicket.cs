using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class PlayTicket : Ticket
    {
        private string headliners;

        public PlayTicket(decimal pr, string ttl, string dt, string time, string loc, string cName, string hdlr)
            :base(pr, ttl, dt, time, loc, cName)
        {
            headliners = hdlr;
        }

        public override string ToString()
        {
            return $"Event:\t\t{title}" +
                $"\nStarring:\t\t{headliners}" +
                $"\nDate:\t\t{date}" +
                $"\nStart Time:\t\t{startTime}" +
                $"\nVenue:\t\t{location}" +
                $"\nTicket Price:\t\t{price.ToString("c")}" +
                $"\n"+
                $"\nIssued for:\t\t{clientName}";
        }
    }
}
