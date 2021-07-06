using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStudentClass
{
    class Student
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public double AverageScore { get; private set; }

        public Student() : this("Unknown", -1)
        {
        }
        public Student(int newIdNumber) : this("Unknown", newIdNumber)
        {
        }
        public Student(string newName) :  this(newName, -1)
        {
        }
        public Student(string newName, int newIdNumber)
        {
            this.Name = newName;
            this.IdNumber = newIdNumber;
        }

        private void UpdateAverageScore()
        {
            AverageScore = (score1 + score2) / 2;
        }

        private int score1;

        public int Score1
        {
            get { return score1; }
            set { score1 = value; UpdateAverageScore(); }
        }
        private int score2;

        public int Score2
        {
            get { return score2; }
            set { score2 = value; UpdateAverageScore(); }
        }

        public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
            }
            }
        }
        public static void DoStuff()
        {
            Student molly = new Student();
            molly.Name = "Molly";
            molly.IdNumber = 42;
            Console.WriteLine("Molly: {0}", molly.Name);
            Console.WriteLine("Molly: {0}", molly.IdNumber);

            Student someStudent = new Student();
            Console.WriteLine("someStudent : {0}", someStudent.Name);
            Console.WriteLine("soemStudent : {0}", someStudent.IdNumber);
        }
    }
}
