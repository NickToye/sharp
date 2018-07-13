using System;
using Xunit;
using Grades;

namespace Grades.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(90, result.HighestGrade);
        }
    }
}
