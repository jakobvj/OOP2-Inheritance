using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExamples
{
    class InheritanceInDepthConstructor
    {
        public InheritanceInDepthConstructor()
        {
            Run();
        }

        private void Run()
        {
            SSchoolStudent schStd = new SSchoolStudent(2, "Newton", new DateTime(1983, 4, 1), 500, 476);
            Console.WriteLine("Age of student, {0}, is {1}. {0} got {2}% marks.",
            schStd.Name, schStd.GetAge(), schStd.GetPercentage());

        }
    }


    class SStudent
    {
        // private Fields
        private int registrationNumber;
        private string name;
        private DateTime dateOfBirth;
        // Student Constructor
        //public SStudent()
        //{
        //    Console.WriteLine("New student created. Parameterless constructor called...");
        //}

        // registrationNumber er private, og kun med get. Så den eneste måde den kan siddes på
        // er vha constructoren
        public SStudent(int registrationNumber, string name, DateTime dateOfBirth)
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
    class SSchoolStudent : Student
    {
        // Private Fields
        private int totalMarks;
        private int totalObtainedMarks;
        private double percentage;
        // Public Constructors
        public SSchoolStudent()
        {
            Console.WriteLine("New school student created. Parameterless constructor called...");
        }
        public SSchoolStudent(int regNum, string name, DateTime dob, int totalMarks, int totalObtainedMarks)
        // : base(regNum, name, dob) // Sender initialiseringen videre til base klassen
        {
            this.Name = name;
            this.DateOfBirth = dob;
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
