using System;
using System.Linq;


namespace StudentAverage
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public decimal GetAverage()
        {
            decimal sum = 0;
            for (int i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }
            
            decimal average = sum / Scores.Length;
            decimal averageRound = Math.Round(average, 0, MidpointRounding.AwayFromZero);
            
            
            return averageRound;
        }
    }
}