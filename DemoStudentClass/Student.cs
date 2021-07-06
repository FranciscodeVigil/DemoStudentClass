using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStudentClass
{
    class Student
    {
        private string name;
        private int idNumber;
        private double score1;
        private double score2;

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
            this.name = newName;
            this.idNumber = newIdNumber;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(String newName)
        {
            name = newName;
        }

        public int GetIdNumber()
        {
            return idNumber;
        }
        public void SetIdNumber(int newIdNumber)
        {
            idNumber = newIdNumber;
        }
        public double GetScore1()
        {
            return score1;
        }

        public void SetScore1(double newScore1)
        {
            score1 = newScore1;
            UpdateAverageScore();
        }

        public double GetScore2()
        {
            return score2;
        }

        public void SetScore2(double newScore2)
        {
            score2 = newScore2;
            UpdateAverageScore();
        }

        private double averageScore;

        public double GetAverageScore()
        {
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score1 + score2) / 2;
        }
        public double GetHighScore()
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

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.name = "Molly";
            molly.idNumber = 42;
            Console.WriteLine("Molly: {0}", molly.name);
            Console.WriteLine("Molly: {0}", molly.idNumber);

            Student someStudent = new Student();
            Console.WriteLine("someStudent : {0}", someStudent.name);
            Console.WriteLine("soemStudent : {0}", someStudent.idNumber);
        }
    }
}
