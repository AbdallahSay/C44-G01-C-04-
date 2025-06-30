using System.Threading.Channels;

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



        }
    }
}
