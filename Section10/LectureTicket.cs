using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    class LectureTicket : Ticket
    {
        private string subject;

        public LectureTicket(decimal pr, string ttl, string dt, string time, string loc, string cName, string sbj)
            : base(pr, ttl, dt, time, loc, cName)
        {
           subject = sbj;
        }

        public override string ToString()
        {
            return $"Event:\t\t{title}" +
                $"\nSubject:\t\t{subject}" +
                $"\nDate:\t\t{date}" +
                $"\nStart Time:\t\t{startTime}" +
                $"\nVenue:\t\t{location}" +
                $"\nTicket Price:\t\t{price.ToString("c")}" +
                $"\n" +
                $"\nIssued for:\t\t{clientName}";
        }
    }
}
