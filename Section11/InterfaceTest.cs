using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section11
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void Test_Traveler()
        {
            Professor prof1 = new Professor("1111", "Adam", "Smith", 56, "Math", "12345");
            Professor prof2 = new Professor("1112", "John", "Wayne", 47, "PE", "98765");
            Student stud1 = new Student("0001", "Amanda", "Pearson", 20, "Gender Studies", "0222");
            Student stud2 = new Student("0002", "Roger", "Stevenson", 21, "Art History", "0244");

            Person[] listOfPeople = new Person[4];

            listOfPeople[0] = prof1;
            listOfPeople[1] = prof2;
            listOfPeople[2] = stud1;
            listOfPeople[3] = stud2;

            foreach (Person someone in listOfPeople)
            {
                Console.WriteLine(someone);
            }
        }
    }
}
