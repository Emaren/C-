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

   // public static void Main()
   // {
   //    double pi = 3.14;
   //    int intPi = (int)pi;
   //    Console.WriteLine(intPi);
   //
   //    double number1 = 10.5;
   //    double number2 = 15;
   //
   //    Console.WriteLine("Math.Abs(number1): " + (Math.Abs(number1)));
   //    Console.WriteLine("Math.Ceiling(number1): " + (Math.Ceiling(number1)));
   //    Console.WriteLine("Math.Floor(number1): " + (Math.Floor(number1)));
   //    Console.WriteLine("Math.Max(number1, number2): " + (Math.Max(number1, number2)));
   //    Console.WriteLine("Math.Min(number1): " + (Math.Min(number1, number2)));
   //    Console.WriteLine("Math.Pow(number1, number2): " + (Math.Pow(number1, number2)));
   //    Console.WriteLine("Math.Round(number1): " + (Math.Round(number1)));
   //    Console.WriteLine("Math.Sqrt(number1): " + (Math.Sqrt(number1)));
   //
   //    Random rand = new Random();
   //    Console.WriteLine("Random number between 1 and 10: " + (rand.Next(1, 11)));
   // }

   // public static void Main()
   // {
   //    int age = 17;
   //
   //    if ((age >= 50) || (age <= 7))
   //    {
   //       Console.WriteLine("Go to elementary school.");
   //    } else if ((age > 7) && (age < 13))
   //    {
   //       Console.WriteLine("Go to junior high school.");
   //    } else
   //    {
   //       Console.WriteLine("Go to high school.");
   //    }
   //
   //    int age2 = 70;
   //
   //    if ((age2 < 14) || (age2 > 65))
   //    {
   //       Console.WriteLine("You should retire.");
   //    }
   //
   //    Console.WriteLine("!true = " + (!true));
   //
   //    bool canDrive = age2 >= 16 ? true : false;
   //
   //    Console.WriteLine(canDrive);
   //
   //    switch (age)
   //    {
   //       case 0:
   //          Console.WriteLine("Mars");
   //          break;
   //       case 1:
   //       case 2:
   //          Console.WriteLine("Earth");
   //          goto Home;
   //       default:
   //          Console.WriteLine("Space");
   //          break;
   //    }
   //
   //    Home:
   //    Console.WriteLine("Earth is home.");
   // }


   public static void Main()
   {
      int i = 0;

      while(i < 10)
      {
         if (i == 2)
         {
            i++;
            continue;
         }

         if (i == 7)
         {
            break;
         }

         if ((i % 2) != 0)
         {
            Console.WriteLine(i);
         }
         i++;
      }


      string guess;

      do
      {
         Console.WriteLine("Guess a Number ");
         guess = Console.ReadLine();

      } while (guess.Equals("15"));


      for (int j = 0; i < 10; j++)
      {
         if ((j % 2) > 0)
         {
            Console.WriteLine(i);
         }
      }


      string randString = "Hey Now Everybody";

      foreach (char c in randString)
      {
         Console.WriteLine(c);
         /* Infinite
            Loop
            Here
            */
      }
   }
}
