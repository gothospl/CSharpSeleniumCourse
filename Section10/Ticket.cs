using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section10
{
    abstract class Ticket
    {
        protected decimal price;
        protected string title;
        protected string date;
        protected string startTime;
        protected string location;
        protected string clientName;

        public Ticket(decimal pr, string ttl, string dt, string time, string loc, string cName)
        {
            price = pr;
            title = ttl;
            date = dt;
            startTime = time;
            location = loc;
            clientName = cName;
        }
    }
}
