namespace DigitalDiary
{
    public abstract class StudentBase : IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void AddGrade();
        public abstract void RemoveGrade();

        public abstract Statistics GetStatistics();
    }
}
