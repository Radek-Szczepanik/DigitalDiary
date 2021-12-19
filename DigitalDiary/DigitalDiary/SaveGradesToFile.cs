using System;
using System.IO;

namespace DigitalDiary
{
    public class SaveGradesToFile : StudentBase
    {
        public override void AddGrade(double grade)
        {
            if (grade > 1 && grade <= 6)
            {
                using (var writer = File.AppendText($"{FirstName}_{LastName}.txt"))
                {
                    writer.Write(grade);
                }
            }
        }

        public override void RemoveGrade()
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            using (var reader = File.OpenText($"{FirstName}_{LastName}.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var grade = double.Parse(line);
                    statistics.Add(grade);
                    line = reader.ReadLine();
                }
            }
            return statistics;
        }
    }
}
