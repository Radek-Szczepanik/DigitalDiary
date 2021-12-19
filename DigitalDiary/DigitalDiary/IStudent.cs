namespace DigitalDiary
{
    public interface IStudent
    {
        string Name { get; set; }
        void AddGrade(double grade);
        void AddStudent();
        void RemoveGrade();
        Statistics GetStatistics();
    }
}
