using System;

public class Demo
{

   // public static void Main()
   // {
   //    Console.Write("What is your name? ");
   //    string name = Console.ReadLine();
   //    Console.WriteLine("Hello " + name + "!");
   // }

   // public static void Main()
   // {
   //    bool canVote = true;
   //
   //    char grade = 'A';
   //
   //    int maxInt = int.MaxValue;
   //
   //    long maxLong = long.MaxValue;
   //
   //    decimal maxDec = decimal.MaxValue;
   //
   //    float maxFloat = float.MaxValue;
   //
   //    double maxDouble = double.MaxValue;
   //    Console.WriteLine("Max Int: " + maxInt);
   //    Console.WriteLine("Max Long: " + maxLong);
   //    Console.WriteLine("Max Dec: " + maxDec);
   //    Console.WriteLine("Max Float: " + maxFloat);
   //    Console.WriteLine("Max Double: " + maxDouble);
   //
   //    var anotherName = "Tony";
   //
   //    Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
   // }

   // public static void Main()
   // {
   //    Console.WriteLine("5 + 3 = " + (5+3));
   //    Console.WriteLine("5 - 3 = " + (5-3));
   //    Console.WriteLine("5 * 3 = " + (5*3));
   //    Console.WriteLine("5 / 3 = " + (5/3));
   //    Console.WriteLine("5 % 3 = " + (5%3));
   //
   //    int i = 0;
   //
   //    Console.WriteLine("i++ = " + (i++));
   //    Console.WriteLine("++i = " + (++i));
   //    Console.WriteLine("i-- = " + (i--));
   //    Console.WriteLine("--i = " + (--i));
   //
   //    Console.WriteLine("i += 2 " + (i += 2));
   //    Console.WriteLine("i -= 2 " + (i -= 2));
   //    Console.WriteLine("i *= 2 " + (i *= 2));
   //    Console.WriteLine("i /= 2 " + (i /= 2));
   //    Console.WriteLine("i %= 2 " + (i %= 2));
   // }

   public static void Main()
   {
      double pi = 3.14;
      int intPi = (int)pi;
      Console.WriteLine(intPi);

      double number1 = 10.5;
      double number2 = 15;

      Console.WriteLine("Math.Abs(number1): " + (Math.Abs(number1)));
      Console.WriteLine("Math.Ceiling(number1): " + (Math.Ceiling(number1)));
      Console.WriteLine("Math.Floor(number1): " + (Math.Floor(number1)));
      Console.WriteLine("Math.Max(number1, number2): " + (Math.Max(number1, number2)));
      Console.WriteLine("Math.Min(number1): " + (Math.Min(number1, number2)));
      Console.WriteLine("Math.Pow(number1, number2): " + (Math.Pow(number1, number2)));
      Console.WriteLine("Math.Round(number1): " + (Math.Round(number1)));
      Console.WriteLine("Math.Sqrt(number1): " + (Math.Sqrt(number1)));

      Random rand = new Random();
      Console.WriteLine("Random number between 1 and 10: " + (rand.Next(1, 11)));
   }

}
