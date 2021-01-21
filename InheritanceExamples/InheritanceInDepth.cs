using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExamples
{
    class InheritanceInDepth
    {
        public InheritanceInDepth()
        {
            Run();
        }

        private void Run()
        {
            Student st = new Student(1, "Fraz", new DateTime(1980, 12, 19));
            Console.WriteLine("Age of student, {0}, is {1}\n", st.Name, st.GetAge());
            SchoolStudent schStd = new SchoolStudent();
            schStd.Name = "Newton";
            schStd.DateOfBirth = new DateTime(1981, 4, 1);
            schStd.TotalMarks = 500;
            schStd.TotalObtainedMarks = 476;
            Console.WriteLine("Age of student, {0}, is {1}. {0} got {2}% marks.",
            schStd.Name, schStd.GetAge(), schStd.GetPercentage());
        }
    }


    class Student
    {
        // private Fields
        private int registrationNumber;
        private string name;
        private DateTime dateOfBirth;
        // Student Constructor
        public Student()
        {
            Console.WriteLine("New student created. Parameterless constructor called...");
        }
        public Student(int registrationNumber, string name, DateTime dateOfBirth)
        {
            this.registrationNumber = registrationNumber;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            Console.WriteLine("New Student Created. Parameterized constructor called...");
        }
        // Public Properties
        public int RegisterationNumber
        {
            get { return registrationNumber; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        // Public Method
        public int GetAge()
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            return age;
        }
    }
    class SchoolStudent : Student
    {
        // Private Fields
        private int totalMarks;
        private int totalObtainedMarks;
        private double percentage;
        // Public Constructors
        public SchoolStudent()
        {
            Console.WriteLine("New school student created. Parameterless constructor called...");
        }
        public SchoolStudent(int regNum, string name, DateTime dob, int totalMarks, int totalObtainedMarks)
        : base(regNum, name, dob)
        {
            this.totalMarks = totalMarks;
            this.totalObtainedMarks = totalObtainedMarks;
            Console.WriteLine("New school student created. Parameterized constructor called...");
        }
        // Public Properties
        public int TotalMarks
        {
            get { return totalMarks; }
            set { totalMarks = value; }
        }
        public int TotalObtainedMarks
        {
            get { return totalObtainedMarks; }
            set { totalObtainedMarks = value; }
        }
        // Public Method
        public double GetPercentage()
        {
            percentage = (double)totalObtainedMarks / totalMarks * 100;
            return percentage;
        }
    }
}
