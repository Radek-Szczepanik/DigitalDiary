namespace DigitalDiary
{
    public interface IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        void AddGrade();
        void RemoveGrade();
        Statistics GetStatistics();
    }
}
