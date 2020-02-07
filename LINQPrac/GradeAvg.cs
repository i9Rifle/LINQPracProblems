using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac
{
    public class Grades
    {
        public string grade;
        public List<string> classGrades = new List<string>()
        {
        "80,100,92,89,65",
        "93,81,78,84,69",
        "73,88,83,99,64",
        "98,100,66,74,55"
        };
        public void CalcGradeAvg()
        {
            var classGradesList = classGrades.Select(s => s.Split(',').Select(n => Convert.ToInt32(n)).ToList().Average()).ToList();

            var averagegrades = classGradesList.Average();
            {
                Console.WriteLine(averagegrades);
            }
        }
    }
}
