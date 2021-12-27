using static DigitalDiary.SaveGradesInMemory;

namespace DigitalDiary
{
    public abstract class StudentBase : IStudent
    {
        public string Name { get; set; }

        public StudentBase() { }

        public event GradeAddedDelegate GradeAdded;

        public abstract void AddStudent();
        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}
