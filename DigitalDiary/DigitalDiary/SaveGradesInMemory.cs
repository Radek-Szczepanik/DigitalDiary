using System;
using System.Collections.Generic;


namespace DigitalDiary
{
    public class SaveGradesInMemory : StudentBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

        public override void AddStudent()
        {
            Console.WriteLine("Enter student name");

            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name can not be empty");
            }
            else
            {
                studentGrades.Add(name, new List<double>());
                Name = name;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                studentGrades[Name].Add(grade);

                if(GradeAdded != null)
                    GradeAdded(this, new EventArgs());
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (int i = 0; i < studentGrades[Name].Count; i++)
            {
                result.Add(studentGrades[Name][i]);
            }

            return result;
        }

        public override void RemoveGrade()
        {
            throw new System.NotImplementedException();
        }
    }
}
