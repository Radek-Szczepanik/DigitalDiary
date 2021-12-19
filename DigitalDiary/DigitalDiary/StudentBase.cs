namespace DigitalDiary
{
    public abstract class StudentBase : IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void AddGrade(double grade);
        public abstract void RemoveGrade();

        public abstract Statistics GetStatistics();
    }
}
