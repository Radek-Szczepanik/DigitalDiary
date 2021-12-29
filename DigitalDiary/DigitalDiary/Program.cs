using System;

namespace DigitalDiary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var saveGrades = new SaveGradesInMemory();
            saveGrades.GradeAdded += OnGradeAdded;
            var statistics = new Statistics();

            while (string.IsNullOrEmpty(saveGrades.Name))
            {
                try
                {
                    saveGrades.AddStudent();
                    Console.WriteLine("Enter grade");
                    Console.WriteLine("Press S to show statistics");
                }

                catch (NullReferenceException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            
            EnterGrade(saveGrades);
            statistics.ShowStatistics(saveGrades.GetStatistics());
        }

        private static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("New grade is added");
        }

        private static void EnterGrade(IStudent student)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "s")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    student.AddGrade(grade);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter number");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Enter grade between 1 and 6");
                }
            }
        }
    }
}
