

namespace DigitalDiary
{
    public abstract class StudentBase : IStudent
    {
        public string Name { get; set; }

        public StudentBase() { }

       

        public abstract void AddStudent();
        public abstract void AddGrade(double grade);
        public abstract void RemoveGrade();

        public abstract Statistics GetStatistics();
    }
}
