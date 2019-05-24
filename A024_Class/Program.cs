using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A024_Class
{
    class CarP
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }

        public CarP(string name, int number, int year)
        {
            Name = name;
            Number = number;
            Year = year;
        }
        public CarP()
        {
        }

        public void Print()
        {
            Console.WriteLine("Name:{0}, Numver:{1}, Year:{2}", Name, Number, Year);
        }
    }
    class Car
    {
        private string name;
        private int number;
        private int year;

        public void SetName(string s)
        {
            name = s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetName("audi");

            CarP x = new CarP();
            x.Name = "audi";
            x.Number = 3049;
            x.Year = 2019;

            CarP y = new CarP("benz", 5423, 2019);

            //Console.WriteLine("Name:{0}, Numver:{1}, Year:{2}", x.Name, x.Number, x.Year);
            x.Print();
            y.Print();
        }
    }
}