using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab.NET
{ 
    class Program
    {
        class Okrujnost
        {
            private double rad;
            public double Rad { get => rad; set => rad = value;}
            public double Area()
            {
                return Math.PI*(Rad*Rad) ;
            }

            public  double Dlina()
            {
                return 2 * Math.PI * Rad;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Окружность: радиус = {Rad}, площадь = {String.Format("{0:f1}", Area())}, длина окружности = {String.Format("{0:f1}", Dlina())}");
            }
        }
   
        static void Main(string[] args)
        {
            Okrujnost okrujnost = new Okrujnost();
            okrujnost.Rad = 3;
            Console.WriteLine($"Площадь: {okrujnost.Area()}");
            Console.WriteLine($"Длина окружности: {okrujnost.Dlina()}");
            Console.ReadLine();
        }
    }
}
