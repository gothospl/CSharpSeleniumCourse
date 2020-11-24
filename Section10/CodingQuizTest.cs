using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class CodingQuizTest
    {
        [TestMethod]
        public void Test_Play_Ticket()
        {
            PlayTicket testTicket = new PlayTicket(9.99M, "Othello", "2021-05-02", "19:00", "Hall C", "Adam Smith", "Brad Pitt, Michael Caine");
            Console.WriteLine(testTicket);
        }

        [TestMethod]
        public void Test_Lecture_Ticket()
        {
            LectureTicket testTicket = new LectureTicket(19.99M, "Orange Man Bad", "2021-02-024", "14:00", "Hall A", "Kamala Harris", "Gender Studies");
            Console.WriteLine(testTicket);
        }

        [TestMethod]
        public void Test_Musical_Ticket()
        {
            MusicalTicket testTicket = new MusicalTicket(14.99M, "Jesus Christ Superstar", "2021-12-25", "19:00", "Hall B", "Adam Darski", "John Williams");
            Console.WriteLine(testTicket);
        }
    }
}
