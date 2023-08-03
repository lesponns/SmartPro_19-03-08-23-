using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_19_03_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double _num1, _num2, _last;
            char _answer;


            do
            {
                Console.Clear();
                Console.Write("First Number: ");
                _num1 = double.Parse(Console.ReadLine());

                Console.Clear();   
                Console.Write("Second Number: ");
                _num2 = double.Parse(Console.ReadLine());

                _last = _num1 + _num2;

                Console.Clear();
                Console.WriteLine("Calculated numbers: " + _num1 + " + " + _num2 + " = " + _last);

                Console.WriteLine("Repeat? OK = R/r ");
                _answer = char.Parse(Console.ReadLine());
            }
            while (_answer == 'R' || _answer == 'r');

            Console.ReadKey();
        }
    }
}
