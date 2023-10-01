using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Lesson5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("В какую систему переводим (2-20)?");
            int system = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % system;
                number /= system;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Получается:  {0}", result);

        }
    }
}
                
            
            
            
