using System;
using System.Collections;
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

        [TestMethod]
        public void Test_Protected()
        {
            DateTime dob = new DateTime(1980, 5, 20);
            Student testStudent = new Student("666", "Anakin", "Skywalker", 23, dob, "Younglings", "3");
            DateTime student_DOB = testStudent.GetDOB();
        }

        [TestMethod]
        public void Test_Student_As_person()
        {
            ArrayList PersonList = new ArrayList();

            DateTime dob = new DateTime(1990, 7, 21);

            Person testPerson = new Person("112", "Luke", "Skywalker", 19, dob);

            Student testStudent = new Student("666", "Anakin", "Skywalker", 23, dob, "Younglings", "3");

            PersonList.Add(testPerson);
            PersonList.Add(testStudent);

            foreach(Person item in PersonList)
            {
                Console.WriteLine(item.HoursOfSleep());
            }
        }

        [TestMethod]
        public void Test_Sealed()
        {
            Pen testPen = new Pen("ball");
        }

    }
}
