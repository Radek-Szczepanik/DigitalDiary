using Xunit;

namespace DigitalDiary.Tests
{
    public class SaveGradesInMemoryTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var grades = new SaveGradesInMemory();
            grades.AddGrade(2.3);
            grades.AddGrade(4.3);
            grades.AddGrade(5.1);
            grades.AddGrade(3.7);

            // act
            var result = grades.GetStatistics();
            
            // assert

            Assert.Equal(3.85, result.Average, 2);
            Assert.Equal(2.3, result.Min);
            Assert.Equal(5.1, result.Max);
            
        }
    }
}
