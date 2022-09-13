using System;

namespace EmployeeLib
{
    public interface IPerformanceReviewer
    {
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

    }
}
