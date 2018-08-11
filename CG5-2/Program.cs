using System;

namespace CG5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a simple calculator that asks the user to input two different numbers and whether they want to add, 
            //subtract, multiple or divide them.
            //Remember our simple calculator program from Class 3 ? Update the application 
            //so that each of the math calculations(add, subtract, multiply, divide) is each
            //in its own method.The methods should return the value and the main method should 
            //print the value.Make sure your methods have XML comments for IntelliSense.Upload 
            //your program to a new repository called CG 5 - 2

            //Program  for the variables first number, second number, answer and operation.  Using double allows for fractions.
            double firstnumber;
            double secondnumber;
            double answer;
            string operation;

            //Ask the user to input the first number.
            Console.WriteLine("Welcome to a simple calculator. Please enter the first number:");
            //Print the user input to the console.
            firstnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the second number.
            Console.WriteLine("Enter the second number");
            //Print the user input to the console.
            secondnumber = Convert.ToDouble(Console.ReadLine());

            //Ask the user to input the operator (x, +, -, or /).  Assumming the user knows symbols for multiplication, division, 
            //subtraction, and addition).
            Console.WriteLine("Enter the operator by typing x, /, +, or -");
            //Print the user input to the console.
            operation = Console.ReadLine();

            //Below calculates and prints the answer to the console depending on which operator chosen as an equation.

            //Checks if the variable to the cases, if not the default is selected. Break has to be used to exit the curly brackets.
            switch (operation)
            {
                case "x":
                    answer = Multiply(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " x " + secondnumber + " = " + answer);
                    break;
                case "/":
                    answer = Divide(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " / " + secondnumber + " = " + answer);
                    break;
                case "+":
                    answer = Addition(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
                    break;
                case "-":
                    answer = Minus(firstnumber, secondnumber);
                    Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.ReadLine();
           
        }

        /// <summary>
        /// Multiplies 2 numbers
        /// </summary>
        /// <param name="num1">first number to be multiplied</param>
        /// <param name="num2">second number to be multiplied</param>
        /// <returns>num1 multipled by num2</returns>
        private static double Multiply(double num1, double num2)
        {
            return (num1 * num2);

        }
        /// <summary>
        /// Divides 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is divided by num2</returns>
        private static double Divide(double num1, double num2)
        {
            return (num1 / num2);

        }
        /// <summary>
        /// Adds 2 numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num1 is added to num2</returns>
        private static double Addition(double num1, double num2)
        {
            return (num1 + num2);

        }
        /// <summary>
        /// Subtracts num2 from num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>num2 is subtracted from num1</returns>
        private static double Minus(double num1, double num2)
        {
            return (num1 - num2);

        }
    }
}
