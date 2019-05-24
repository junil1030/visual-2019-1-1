using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A001_bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("체중을 입력하시오. ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("키를 입력하시오. ");
            double h = double.Parse(Console.ReadLine());
            h /= 100;

            double BMI = w / (h * h);
            Console.WriteLine("BMI = {0}", BMI);
        }
    }
}
