using System;

public class Demo
{

   // public static void Main()
   // {
   //    Console.Write("What is your name? ");
   //    string name = Console.ReadLine();
   //    Console.WriteLine("Hello " + name + "!");
   // }

   public static void Main()
   {
      bool canVote = true;

      char grade = 'A';

      int maxInt = int.MaxValue;

      long maxLong = long.MaxValue;

      decimal maxDec = decimal.MaxValue;

      float maxFloat = float.MaxValue;

      double maxDouble = double.MaxValue;
      Console.WriteLine("Max Int: " + maxInt);
      Console.WriteLine("Max Long: " + maxLong);
      Console.WriteLine("Max Dec: " + maxDec);
      Console.WriteLine("Max Float: " + maxFloat);
      Console.WriteLine("Max Double: " + maxDouble);

      var anotherName = "Tony";

      Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
      
   }

}
