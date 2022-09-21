﻿using System;

namespace EmployeeLib
{
    public class CEO : Employee, IPerformanceReviewer
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public void FireSomeone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
