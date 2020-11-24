using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class InhertianceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            //Person testPerson = new Person("1234", "Palpatine", "Sheev", 72);

            //Student testStudent = new Student("666", "Anakin", "Skywalker", 23, "Younglings", "3");

            //string response = testStudent.GetExcerciseHabits();
        }

        [TestMethod]
        public void Composition_Test()
        {
            DateTime dob = new DateTime(1980, 5, 20);
            Student testStudent = new Student("666", "Anakin", "Skywalker", 23, dob, "Younglings", "3");
        }
    }
}
