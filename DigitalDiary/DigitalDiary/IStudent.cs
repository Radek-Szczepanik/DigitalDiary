namespace DigitalDiary
{
    public interface IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        void AddGrade(double grade);
        void RemoveGrade();
        Statistics GetStatistics();
    }
}
