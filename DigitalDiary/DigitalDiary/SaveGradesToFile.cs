using System;
using System.IO;

namespace DigitalDiary
{
    public class SaveGradesToFile : StudentBase
    {
        public new event GradeAddedDelegate GradeAdded;
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
                Name = name;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writeGrades = File.AppendText($"{Name}.txt"))
                using (var dateTimeGrades = File.AppendText($"{Name}.audit.txt"))
                {
                    writeGrades.WriteLine(grade);
                    dateTimeGrades.WriteLine($"{grade} - {DateTime.UtcNow}");

                    if (GradeAdded != null)
                        GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var grade = double.Parse(line);
                    statistics.Add(grade);
                    line = reader.ReadLine();
                }
            }
            return statistics;
        }
    }
}
