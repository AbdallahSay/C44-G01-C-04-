using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
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
            //Console.Write("Enter an integer: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            //int reversedNumber = 0;
            //if (isParsed)
            //{
            //    while (number != 0)
            //    {
            //        int digit = number % 10;
            //        reversedNumber = reversedNumber * 10 + digit;
            //        number /= 10;
            //    }

            //    Console.WriteLine("Reversed number: " + reversedNumber);
            //}



            #endregion
            #region 15- Write a program in C# Sharp to find prime numbers within a range of  numbers.
            //    Console.Write("Enter starting number of range: ");
            //    int start = int.Parse(Console.ReadLine());

            //    Console.Write("Enter ending number of range: ");
            //    int end = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Prime numbers between {0} and {1} are:", start, end);
            //    for (number = start; number <= end; number++)
            //    {
            //        if (IsPrime(number))
            //        {
            //            Console.Write(number + " ");
            //        }
            //    }
            //}

            //static bool IsPrime(int num)
            //{
            //    if (num <= 1)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }

            //    return true;


            #endregion
            #region 16 -. Write a program in C# Sharp to convert a decimal number into binary  without using an array. 

            //Console.Write("Enter a number to convert: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number) && number >= 0)
            //{
            //    string binary = "";

            //    if (number == 0)
            //    {
            //        binary = "0";
            //    }
            //    else
            //    {
            //        while (number > 0)
            //        {
            //            int remainder = number % 2;
            //            binary = remainder + binary;
            //            number /= 2;
            //        }
            //    }

            //    Console.WriteLine("The Binary of the number is: " + binary);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion
            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a  single straight line.
            //Console.WriteLine("please enter point 1 x , y");
            //bool isParsedX1 = double.TryParse(Console.ReadLine(), out double x1);
            //bool isParsedY1 = double.TryParse(Console.ReadLine(), out double y1);
            //Console.WriteLine("please enter point 2 x , y");
            //bool isParsedX2 = double.TryParse(Console.ReadLine(), out double x2);
            //bool isParsedY2 = double.TryParse(Console.ReadLine(), out double y2);
            //Console.WriteLine("please enter point 1 x , y");
            //bool isParsedX3 = double.TryParse(Console.ReadLine(), out double x3);
            //bool isParsedY3 = double.TryParse(Console.ReadLine(), out double y3);
            //bool onSamePoint = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

            //if(onSamePoint)
            //    Console.WriteLine("The points lie on a single straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");




            #endregion
            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 

            //Console.WriteLine("Please enter your rate from Hours1");
            //bool isParsed1 = int.TryParse(Console.ReadLine(), out int houre1);
            //Console.WriteLine("Please enter your rate to Hours2");
            //bool isParsed2 = int.TryParse(Console.ReadLine(), out int houre2);

            //if(isParsed1 && isParsed2)
            //{
            //    if(houre1 == 2 || houre2 == 3)
            //        Console.WriteLine("highly efficient.");
            //    else if (houre1 == 3 || houre2 == 4 )
            //        Console.WriteLine(" they are instructed to increase their speed.");
            //    else if (houre1 == 4 || houre2 == 5 )
            //        Console.WriteLine(" they are provided with training to \r\nenhance their speed. ");
            //    else if (houre1 == 6 || houre2 >= 6)
            //        Console.WriteLine(" they are required to leave the \r\ncompany. ");

            //}

            #endregion
            #region 19-  Write a program that prints an identity matrix using for loop
            //Console.WriteLine("please enter Intager Value n");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int matrix);
            //Console.Clear();
            //if (isParsed) 
            //{
            //    for (int i = 0;  i < matrix; i++)
            //    {
            //        for(int j = 0; j < matrix; j++)
            //        {
            //            if(j == i )
            //                Console.Write("1");
            //            else
            //                Console.Write("0");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //    Console.WriteLine("Invalid integer number ");
            #endregion
            #region 20-find the sum of all elements of the  array.
            //int[] arr = [4, 5, 6, 7, 8];
            //double sumOfArr = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    sumOfArr += arr[i];
            //Console.WriteLine($"Sum Of Array = {sumOfArr}");


            #endregion
            #region 21- merge two arrays of the same size sorted in ascending order.
            //    int[] arrOne = { 1, 10, 4, 2 };
            //    int[] arrTwo = { 3, 7, 5, 6 };
            //    int[] marged = new int[arrOne.Length + arrTwo.Length];
            //    for (int i = 0; i < arrOne.Length; i++)
            //    {

            //        marged[i] = arrOne[i];

            //    }
            //    for (int i = 0; i < arrTwo.Length; i++)
            //    {

            //        marged[arrOne.Length + i] = arrTwo[i];

            //    }

            //    Console.WriteLine("Marged Array");
            //    for (int i = 0; i < marged.Length; i++) { 
            //    Array.Sort(marged);
            //    Console.Write(marged[i] + "  ");
            //}

            #endregion
            #region -22 count the frequency of each element of  an array.
            //int[] arr = { 1, 2, 3, 4, 5, 6, 6, 7, 4, 3, 5, 7, 9, 7 };
            //int count;

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    bool alreadyPrinted = false;
            //    for (int k = 0; k < i; k++)
            //    {
            //        if (arr[k] == arr[i])
            //        {
            //            alreadyPrinted = true;
            //            break;
            //        }
            //    }

            //    if (alreadyPrinted)
            //        continue;


            //    count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr[i])
            //            count++;
            //    }

            //    Console.WriteLine($"{arr[i]} frequency = {count}");
            //}




            #endregion
            #region 23- find maximum and minimum element in an  array
            //int[] arr = { 1, 2, 3, 4, 5, 6, 6, 7, 4, 3, 5, 7, 9, 7 };
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i] ;

            //    if (arr[i] < min)
            //        min = arr[i];


            //}
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");



            #endregion
            #region 24- find the second largest element in an array.

            //int[] arr = { 10, 7, 25, 3, 19, 25 };

            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] < max)
            //    {
            //        secondMax = arr[i];
            //    }
            //}

            //Console.WriteLine("Second Largest = " + secondMax);

            #endregion
            #region 25- find the longest distance between Two equal cells
            //Console.WriteLine("Enter array size");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int arr);

            //if (isParsed && arr > 0)
            //{
            //    int[] numbers = new int[arr];
            //    for (int i = 0; i < arr; i++)
            //    {
            //        Console.WriteLine($"Enter array element {i + 1}:");
            //        bool flagElement = int.TryParse(Console.ReadLine(), out int element);
            //        if (flagElement)
            //            numbers[i] = element;
            //        else
            //        {
            //            Console.WriteLine("Invalid number");
            //            i--; 
            //        }
            //    }

            //    Console.Clear();
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        Console.Write(numbers[j] + "  ");
            //    }

            //    Console.WriteLine();
            //    int maxDistance = 0;
            //    int repeatedNumber = 0;

            //    for (int i = 0; i < arr; i++)
            //    {
            //        for (int j = arr - 1; j > i; j--)
            //        {
            //            if (numbers[j] == numbers[i])
            //            {
            //                int distance = j - i - 1;
            //                if (distance > maxDistance)
            //                {
            //                    maxDistance = distance;
            //                    repeatedNumber = numbers[i]; 
            //                }
            //                break;
            //            }
            //        }
            //    }

            //    Console.WriteLine($"\nThe longest distance is: {maxDistance}, between number: {repeatedNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid array size.");
            //}


            #endregion
            #region 26-Given a list of space separated words, reverse the order of the words
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);

            //string result = string.Join(" ", words); 

            //Console.WriteLine(result);

            #endregion
            #region 27-- Write a program to create two multidimensional arrays of same size.    Accept value from user and store them in first array. Now copy all the  elements of first array on second array and print second array.
            int rows, cols;
            Console.Write("Enter number of rows: ");
            bool flagRows = int.TryParse(Console.ReadLine(), out rows);

            Console.Write("Enter number of columns: ");
            bool flagCols = int.TryParse(Console.ReadLine(), out cols);

            if (flagRows && flagCols && rows > 0 && cols > 0)
            {
                int[,] firstArray = new int[rows, cols];
                int[,] secondArray = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Enter element [{i}, {j}]: ");
                        bool flagElement = int.TryParse(Console.ReadLine(), out int value);

                        if (flagElement)
                        {
                            firstArray[i, j] = value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again.");
                            j--; // يرجع يطلب نفس العنصر
                        }
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        secondArray[i, j] = firstArray[i, j];
                    }
                }

                Console.WriteLine("\nCopied Second Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(secondArray[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid size. Please enter positive numbers only.");
            }

            #endregion
        }
    }
}


            