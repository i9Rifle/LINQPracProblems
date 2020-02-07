using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            Grades myGrades = new Grades();
            myGrades.CalcGradeAvg();


            Word word = new Word();
            word.GetWords();

            Name name = new Name();
            name.GetList();



        }
    }
}
