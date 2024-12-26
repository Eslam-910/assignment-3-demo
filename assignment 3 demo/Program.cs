using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace assignment_3_demo
{
    internal class Program
    {
        static void Main()
        {
            #region Control statment
            //control statment
            //Console.Write("enter number of month in the 1st quarter : ");
            //int MonthNumber=int.Parse(Console.ReadLine());
            // jan
            //feb
            //mar
            //Console.WriteLine("jan");
            //Console.WriteLine("feb"); 
            //Console.WriteLine("mar");
            //if (true)
            //{
            //    Console.WriteLine("Helllo World");
            //}

            //if (MonthNumber == 1) {
            //    Console.WriteLine("jan");
            //}
            //if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalide Month Number");
            //}
            //using switch
            //switch(/*Expression*/)
            //{

            //}

            //Console.Write("enter number of month in the 1st quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            ////jump Table
            //switch (MonthNumber) 
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Number");
            //        break;


            //};
            #endregion
            #region conditional statments if switch
            //Console.Write("Enter Your Name");
            //string Name = Console.ReadLine();
            //if (Name == "Ahmed" || Name == "ahmed")
            //{
            //    Console.WriteLine("Hi Ahmed");
            //}
            //else if (Name == "Omar" || Name == "omar")
            //{
            //    Console.WriteLine("Hi Omar");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine("Hi Ali");
            //}
            //else if (Name == "Mariam" || Name == "mariam")
            //{
            //    Console.WriteLine("Hi Mariam");
            //}

            // switch case
            //    Console.Write("Enter Your Name");
            //    string Name = Console.ReadLine();
            //    switch (Name) 
            //    {
            //        case "Ahmed":
            //        case "ahmed":
            //            Console.WriteLine("Hi Ahmed");
            //            break;

            //        case "Omar":
            //        case "omar":
            //            Console.WriteLine("Hi Omar");
            //            break;
            //        case "Ali":
            //        case "ali":
            //            Console.WriteLine("Hi Ali");
            //            break;
            //        case "Mariam":
            //        case "mariam":
            //            Console.WriteLine("Hi Mariam");
            //            break;
            //    }
            #endregion
            #region 
            //Console.Write("Enter Your Age");
            //int Age=int.Parse(Console.ReadLine());

            //if(Age>18)
            //    Console.WriteLine("Welcome :(");
            //else if(Age<18)
            //    Console.WriteLine("Bye Bye :)");
            //else
            //{
            //    Console.WriteLine("Equal !!");
            //}

            //Console.Write("Enter Your Age :- ");
            //int Age=int.Parse(Console.ReadLine());
            //switch (Age) 
            //{
            //    case > 18:
            //        Console.WriteLine("welcome");
            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye Bye");
            //        break;
            //    default:
            //        Console.WriteLine("equal !!");
            //        break;
            //}
            #endregion
            #region evolution switch
            //object Object=new object();
            //Object = "Ahmed";
            //Object = 1;
            //switch (Object) 
            //{
            //    case int X when X> -12:
            //        Console.WriteLine("Hello World");
            //        break;
            //    case string X when X.Length > 5:
            //        Console.WriteLine("Hello World");
            //        break;
            //    case string X when X.Length < 5:
            //        Console.WriteLine("Hello World");
            //        break;

            //}
            #endregion
            #region c# 8
            //var s = 7;
            //Console.WriteLine(s);
            //string input=Console.ReadLine();
            //Console.WriteLine( input switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "unsupport option"

            //});
            #endregion
            #region forloop
            //for (/*statment*//*expression*//*statment*/)
            //{
            //    //code

            //}
            //for (int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("Hello ,world");

            //}
            //int i = 1;
            //for (Console.WriteLine("Hello 1");i<=10;Console.WriteLine("Hello 2"))
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}
            #endregion
            #region froeach
            //int[] number = {1,2,3,4,5,6,7};
            ////for(int i=0;i<number.Length;i++) {
            ////    Console.WriteLine(number[i]);

            ////}

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region while and do while

            //while (true) {
            //    Console.WriteLine("Hello World");
            //}
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello");
            //    i++;
            //}
            //int i = 1;
            //do {
            //    Console.WriteLine("Hello World!");
            //    i++;

            //}while (i<=10);
            #endregion
            #region String
            //string S01;
            //S01 = "Ahmed";

            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine("Hash Table : "+message.GetHashCode());
            //Console.WriteLine();

            //message += "Ahmed";
            //Console.WriteLine(message);
            //Console.WriteLine("Hash Code : " + message.GetHashCode());
            #endregion
            #region String Builder
            //StringBuilder S01;
            
            //S01 = new StringBuilder("Hello");
            ////new
            ////1.allocated the required number of bytes for the object at heap(8+)
            ////2.initialized alllocated bytes at heap with the (default value=0)
            ////3.call user defind constructor if exists
            ////4.assign the object reference(S01)
            //Console.WriteLine("S01: "+S01);
            //Console.WriteLine("HashCode: " + S01.GetHashCode());
            //Console.WriteLine();

            //S01.Append("Ahmed");
            //Console.WriteLine("S01: " + S01);
            //Console.WriteLine("HashCode: " + S01.GetHashCode());
            #endregion

        }
    }
}
