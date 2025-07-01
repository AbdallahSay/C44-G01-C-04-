using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Plase enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isParsed && (number % 3 == 0 || number % 4 == 0))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            //#endregion



            #endregion
            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("please enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isParsed)
            //{
            //    if(number > 0 )
            //        Console.WriteLine("Positive");
            //    else if (number < 0)
            //        Console.WriteLine("Negative");
            //    else
            //        Console.WriteLine("Number = 0");
            //}
            #endregion
            #region 3-- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("please enter number1");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);
            //Console.WriteLine("please enter number2");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);
            //Console.WriteLine("please enter number3");
            //bool isParsed3 = int.TryParse(Console.ReadLine(), out int number3);
            //int max = number1;
            //if (number2 > max) max = number2;
            //if (number3 > max) max = number3;

            //int min = number1;
            //if (number2 < min) min = number2;
            //if (number3 < min) min = number3;

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);



            #endregion
            #region -4 Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("please enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isParsed)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine("Even");
            //    else
            //        Console.WriteLine("Odd");
            //}


            #endregion
            #region 5- Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant). 
            //Console.WriteLine("Please enter Vowel Char");
            //bool isParsed = char.TryParse(Console.ReadLine().ToLower() , out char vowel );

            //if (isParsed)
            //{
            //    if(vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            //        Console.WriteLine("vowel");
            //    else
            //        Console.WriteLine("consonant");
            //}





            #endregion
            #region 6- Write a program that allows the user to insert an integer then print   all numbers between 1 to that number.
            //Console.WriteLine("please enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //Console.Clear();
            //for (int i = 1; i <= number; i++)
            //    Console.WriteLine(i);



            #endregion
            #region 7 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //int i= 0;
            //Console.WriteLine("please enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //Console.Clear();
            //for (i = 1; i<= 12; i++)
            //{
            //    Console.WriteLine(number*i);

            //}



            #endregion
            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("please enter number");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            //Console.Clear();
            //if (isParsed) {
            //    for (int i = 1; i <= number; i++)
            //        if (i % 2 == 0)
            //            Console.WriteLine(i);

            //}



            #endregion
            #region  9 - Write a program that takes two integers then prints the power.
            //Console.WriteLine("please enter base");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int baseNum);
            //Console.WriteLine("please enter exponent");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int exponent);
            //Console.Clear();
            //if (isParsed1 & isParsed2)
            //{
            //    Console.WriteLine(Math.Pow(baseNum, exponent));

            //}
            //else
            //    Console.WriteLine("Invalid input");
            #endregion
            #region 10- Write a program to enter marks of five subjects and calculate total,  average and percentage.

            //int[] marks = { 100, 50, 79, 80, 90 };
            //double total = 0;
            //for(int i = 0; i < marks.Length; i++)
            //{
            //    total += marks[i];

            //}
            //Console.WriteLine($"total = {total}");
            //double avg = total / marks.Length;
            //Console.WriteLine($"average = {avg}");
            //double Percentage = (total * 100) / 500;
            //Console.WriteLine($"Persentage = {Percentage}%");


            #endregion
            #region 11- Write a program to input the month number and print the number of days in that month.

            // Console.Write("Enter month number (1-12): ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int month);

            // if (isParsed) {
            //     if (month == 1 || month == 3 || month == 5 || month == 7 ||
            //        month == 8 || month == 10 || month == 12)
            //     {
            //         Console.WriteLine("Days in Month: 31");
            //     }
            //     else if (month == 4 || month == 6 || month == 9 || month == 11)
            //     {
            //         Console.WriteLine("Days in Month: 30");
            //     }
            //     else if (month == 2)
            //     {
            //         Console.WriteLine("Days in Month: 28");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid month number.");
            //     }

            // }
            // else
            //     Console.WriteLine("Invalid input");

            #endregion
            #region 12- Write a program to create a Simple Calculator. 
            //Console.WriteLine("Simple Calculator:");

            //Console.Write("Enter first number: ");
            //double firstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char operation = char.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double secondNumber = double.Parse(Console.ReadLine());

            //double result;

            //if (operation == '+')
            //{
            //    result = firstNumber + secondNumber;
            //    Console.WriteLine("Result = " + result);
            //}
            //else if (operation == '-')
            //{
            //    result = firstNumber - secondNumber;
            //    Console.WriteLine("Result = " + result);
            //}
            //else if (operation == '*')
            //{
            //    result = firstNumber * secondNumber;
            //    Console.WriteLine("Result = " + result);
            //}
            //else if (operation == '/')
            //{
            //    if (secondNumber != 0)
            //    {
            //        result = firstNumber / secondNumber;
            //        Console.WriteLine("Result = " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Cannot divide by zero.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator.");
            //}
            #endregion
            #region 13-  Write a program to allow the user to enter a string and print the  REVERSE of it.


            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine("Reversed string: " + reversed);


            #endregion
            #region 14- Write a program to allow the user to enter int and print the REVERSED  of it.
            Console.Write("Enter an integer: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            int reversedNumber = 0;
            if (isParsed)
            {
                while (number != 0)
                {
                    int digit = number % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    number /= 10;
                }

                Console.WriteLine("Reversed number: " + reversedNumber);
            }



            #endregion
            #region 15- Write a program in C# Sharp to find prime numbers within a range of  numbers.
            Console.Write("Enter starting number of range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1} are:", start, end);
            for (number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;


            #endregion
            #region 16 -. Write a program in C# Sharp to convert a decimal number into binary  without using an array. 

            Console.Write("Enter a number to convert: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0)
            {
                string binary = "";

                if (number == 0)
                {
                    binary = "0";
                }
                else
                {
                    while (number > 0)
                    {
                        int remainder = number % 2;
                        binary = remainder + binary;
                        number /= 2;
                    }
                }

                Console.WriteLine("The Binary of the number is: " + binary);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            #endregion

        }
    }
}


            