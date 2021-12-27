namespace DigitalDiary
{
    public interface IStudent
    {
        string Name { get; set; }
        void AddGrade(double grade);
        void AddStudent();
        Statistics GetStatistics();

        event GradeAddedDelegate GradeAdded;
    }
}
