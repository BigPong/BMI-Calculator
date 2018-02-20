using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Height(m):");
            string height = Console.ReadLine();

            Console.Write("Weight(kg):");
            string weight = Console.ReadLine();

            float bmi = float.Parse(weight) / (float.Parse(height) * float.Parse(height));
            
            Console.WriteLine("BMI: "+bmi.ToString());

            Console.ReadLine();
        }
    }
}
