
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, result;
            char sign;

            Console.WriteLine("Hi, user. Please, enter first number.");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter operation character: +, -, * or /.");
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please, enter second number.");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            if (sign == '+')
            {
                result = firstNumber + secondNumber;
                Console.WriteLine("The sum of your values is: " + result);
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = firstNumber - secondNumber;
                Console.WriteLine("The result of your subtraction is: " + result);
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("The result of your subtraction is: " + result);
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error. Divider cannot be 0.");
                    Console.WriteLine("Press any button to exit.");
                    Console.ReadKey();
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The result of your division is: " + result);
                    Console.WriteLine("Press any button to exit.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("You entered incorrect value.");
                Console.WriteLine("Press any button to exit.");
                Console.ReadKey();
            }



        }
    }
}


