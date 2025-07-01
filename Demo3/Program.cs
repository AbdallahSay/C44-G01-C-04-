using System.Globalization;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditional Statements EX1:
            //if (age > 22)
            //    Console.WriteLine($"Your age > 22 = {age}");
            //else if (age < 22)
            //    Console.WriteLine($"Your age < 22 = {age}");
            //else
            //    Console.WriteLine($"Your age = 22");
            //Console.WriteLine("Please Enter Your Age"); // Relational Pattern -- No jump table
            //int.TryParse(Console.ReadLine(), out int age);
            //switch (age)
            //{
            //    case (< 22):
            //    Console.WriteLine($"Your age > 22 = {age}");
            //        break;
            //    case (> 22):
            //        Console.WriteLine($"Your age > 22 = {age}");
            //        break;
            //    default:
            //              Console.WriteLine($"Your age > 22 = {age}");
            //        break;




            //}


            #endregion
            #region  Conditional Statements EX2(Name -- Hello)
            //if (name == "Abdallah")
            //    Console.WriteLine("Hello Abdallah");
            //else if (name == "Mo")
            //    Console.WriteLine("Hello Mo");
            //else
            //    Console.WriteLine($"Hello {name}");
            //Console.WriteLine("Please Enter Your Name");
            //String name = Console.ReadLine();
            //switch (name)
            //{
            //    case ("Abdallah"):
            //        Console.WriteLine("Hello abdallah");
            //        break;
            //    case ("Mo"):
            //        Console.WriteLine("Hello mo");
            //        break;
            //    default:
            //        Console.WriteLine($"hello {name}");
            //        break;

            //}

            #endregion
            #region Conditional Statements EX3

            //if (budget == 1000)
            //    Console.WriteLine("Option1");
            //else if (budget == 2000)
            //{
            //    Console.WriteLine("Option1");
            //    Console.WriteLine("Option2");
            //}
            //else if (budget == 3000)
            //{
            //    Console.WriteLine("Option1");
            //    Console.WriteLine("Option2");
            //    Console.WriteLine("Option3");

            //}

            //else
            //    Console.WriteLine("Unknown");

            //Console.WriteLine("Please Enter Your Budget");
            //double.TryParse(Console.ReadLine(), out double budget);
            //switch (budget)
            //{
            //    case (1000):
            //        Console.WriteLine("Option1");
            //        break;
            //    case (2000):
            //            Console.WriteLine("Option2");
            //        goto case 1000;
            //    case (3000):
            //        Console.WriteLine("Option3");
            //        goto case 2000;
            //        break;
            //    default:
            //        Console.WriteLine("UnKnown");
            //        break;


            //}

            #endregion
            #region goto
            //abdol:
            //    Console.WriteLine("Hello abdol");

            //    Console.WriteLine("please enter num");
            //    int.TryParse(Console.ReadLine(), out int num);
            //    goto abdol;
            #endregion
            #region Switch(C#7  , Pattern Matching and When Keyword)
            //object obj;
            //obj = 3;

            //switch (obj) {
            //    case int x:
            //        Console.WriteLine("Integer");
            //        break;
            //        case float x:
            //        Console.WriteLine("Single");
            //        break;
            //        case double x:
            //        Console.WriteLine("Double");
            //            break;
            //    default:
            //        Console.WriteLine("UnKnown");
            //        break;

            //}
            //switch (obj)
            //{
            //    case int x when x<=10 && x>= 3 :
            //        Console.WriteLine("Integer");
            //        break;
            //    case float x:
            //        Console.WriteLine("Single");
            //        break;
            //    case double x:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("UnKnown");
            //        break;

            //}
            //Object obj = new person() { Id = 2202110 , Age = 21, Name = "Abdallah" };
            //switch (obj)
            //{

            //    case int input:
            //        Console.WriteLine("int datatype");
            //        break;
            //    case string input:
            //        Console.WriteLine("string data type");
            //        break;
            //    case person input when input.Id == 2202110:
            //        Console.WriteLine("Person datatype");
            //        break;
            //}





            #endregion
            #region Switch C#8 (without alies name , switch expressions)
            #region Without Alies
            //object obj;
            //obj = 10;
            //switch (obj)
            //{
            //    case int when (int)obj >= 10:
            //        Console.WriteLine("Integer");
            //        break;
            //    case string:
            //        Console.WriteLine("String");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown");
            //        break;
            //}

            #endregion
            #region Switch Expression (Constant - discard)
            //Console.WriteLine("Please enter your number[1 2 3]");
            //int.TryParse(Console.ReadLine(), out int number);

            //string result = number switch
            //{
            //    1 => "Option1",
            //    2 => "Option2",
            //    3 => "Option3",
            //    _ => "Nuknown"

            //};
            //Console.WriteLine(result);


            #endregion
            #region Property Pattern
            //Person person = new Person(){ Id = 10, Name = "Abdallah" ,Age = 21};
            //string result = person switch
            //{
            //    { Id : 10 , Name: "Abdallah" , Age : 21 } => "Hello Abdallah",
            //    _ => "UnKnown"
            //};
            //Console.WriteLine(result);
            #endregion
            #region Nullable and relational pattern
            //int?
            //int? number = null;
            //string result = number switch
            //{
            //    null => "Null",
            //    int x when x > 0 => "Positive",
            //    int x when x < 0 => "Negative",
            //    _ => "zero"
            //};
            //Console.WriteLine(result);
            #endregion




            #endregion
            #region Switch C# 9.0
            #region Relational Pattern 
            //Console.WriteLine("Please Enter Your Number");
            //int.TryParse(Console.ReadLine(), out int number);
            //string Result = number switch
            //{
            //    < 10 => "number < 10",
            //    > 20 => "Number > 20",
            //    >= 10 and <= 20 => "Number between 10 and 20"
            //};
            //Console.WriteLine(Result);

            #endregion
            #region Enhanced Property pattern
            //Person person = new Person() { Id = 10, Age = 40, Name = "Abdol" };
            //string res = person switch
            //{
            //    {  Age: >10,Name: "Abdol"} => $"Hello {person.Name}",
            //    {  Age: >20 and <= 30,Name: "Omar"} => $"Hello Omar",
            //    {  Age: >40 and <= 50} => $"Hello {person.Name}",


            //};
            //Console.WriteLine(res);


            #endregion
            #endregion
            #region For & Foreach
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];
            //for(int i = 0; i <= numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //    //Can't access specific element
            // }
            //Person[] persons = new Person[] { new Person { Id = 10, Age = 21, Name = "abdol" },
            //new Person { Id = 20, Age = 21, Name = "mo" }};
            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            ///// with break - continue
            //for(int i = 1; i < 10; i++)
            //{
            //    if(i ==2)
            //    continue;
            //    Console.WriteLine(i);//13456789
            //}
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 2)
            //        break;
            //    Console.WriteLine(i);//1
            //}


            #endregion
            #region While - do while

            //bool isParsed;
            //int number;
            //do
            //{
            //    Console.WriteLine("PLease Enter an even number");
            //    isParsed = int.TryParse(Console.ReadLine(), out number);


            //} while (!isParsed || number % 2 == 1);
            ///// لو هو رقم فردي ارجع نفذ do واخرج اول ما يجيلك رقم even 
            //Console.WriteLine(number);
            //int number;
            //bool isParsed;
            //Console.WriteLine("PLease enter number");
            //isParsed = int.TryParse(Console.ReadLine(), out number);
            //if (isParsed)
            //{
            //    Console.Clear();
            //    while(number <= 10)
            //    {
            //        Console.WriteLine(number);
            //        number++;
            //    }
            //}




            #endregion
            #region String
            //string name = "Abdallah";
            //string name2 = "Abdallah";//Unreachable 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //name2 = "Abdol";
            //Console.WriteLine();
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            ///Methods
            ///static (class member) 
            ///non-static (object member)
            //string name = "             abdol           ";
            ////Console.WriteLine(name.Length);//Prorerty
            ////Console.WriteLine(name.ToLower());
            ////Console.WriteLine(name.ToUpper());
            ////Console.WriteLine(name.Replace("abdol" ,"body"));
            ////Console.WriteLine(name.Replace("a" ,"A"));
            ////Console.WriteLine(name.Remove(0 ,5));
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.TrimStart());
            //Console.WriteLine(name.TrimEnd());

            #endregion
            #region StringBuilder
            //StringBuilder name;
            ////Allocate 4 byte in stack for reference
            ////name = "abdol" invalid
            ////name = new StringBuilder("Abdol");
            ////Console.WriteLine(name);
            ////Console.WriteLine(name.GetHashCode());
            //////name += "Sayed"; //invalid
            ////name.Append(" Sayed");
            ////Console.WriteLine();
            ////Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            //StringBuilder name1 = new StringBuilder("Abdallah");
            //StringBuilder name2 = new StringBuilder();
            //name2.Append("Abdallah");
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode()); 

            //Console.WriteLine("Change name1");
            //name1 = name2;
            //Console.WriteLine();
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine();
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //Console.WriteLine();

            ///Methods
            //StringBuilder msg = new StringBuilder();
            //msg.AppendLine("Abdallah");
            //msg.Append("Hello");
            //Console.WriteLine(msg);
            //msg.AppendFormat("Yourname is {0}", msg);
            //Console.WriteLine(msg.GetHashCode());
            //Console.WriteLine(msg.Clear());
            //Console.WriteLine(msg.GetHashCode());







            #endregion
            #region 1D Array
            //Array arr = new Array();// invalid
            //int[] numbers = new int[5];
            //int[] numbers = [1, 2, 3, 4, 5];
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numbers = new int[5];
            //Array.Fill(numbers, 5);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Array arr = Array.CreateInstance(typeof(int), 5);
            //arr.SetValue(10, 0);
            //arr.SetValue(20, 1);
            //arr.SetValue(30, 2);
            //arr.SetValue(40, 3);
            //Console.WriteLine(arr.GetValue(3));

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //for(int i = 0; i < numbers.Length;)
            //{
            //    Console.WriteLine($"please enter number in {i+1}");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //        if (isParsed)
            //    {
            //        i++;
            //    }

            //}
            //Console.Clear();
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = new int[5];
            //Array.Fill(numbers, 9);
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion


        }
    }
}
