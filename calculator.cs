using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaAgy
{
    class calculator
    {
        static void main(string[] args)
        {
            int op;
            Console.WriteLine("Operations");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            op = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            var result = new Calculate();
            switch(op)
            {
                case 1:
                Console.WriteLine("the sum of two  numbers {0} and {1} =  {2}",num1, num2, result.Add(num1,num2));
                Console.ReadKey();
                break;
                case 2:
                Console.WriteLine("the difference of two numbers {0} and {1} = {2}", num1, num2, result.Subtraction(num1, num2));
                Console.ReadKey();
                break;
                case 3:
                Console.WriteLine("the product of two numbers {0} and {1} = {2}", num1, num2, result.Multiplication(num1, num2));
                Console.ReadKey();
                break;
                case 4:
                Console.WriteLine("the quotient of two numbers {0} and {1} = {2}", num1, num2, result.Division(num1, num2));
                Console.ReadKey();
                break;
                default:
                Console.WriteLine("operand not specified");
                Console.ReadKey();
                break;
            }
        }
    }
}
