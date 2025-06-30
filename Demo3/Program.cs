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


        }
    }
}
