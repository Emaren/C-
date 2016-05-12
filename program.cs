using System;
using System.Text;
using System.Collections.Generic;

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


   // public static void Main()
   // {
   //    int i = 0;
   //
   //    while(i < 10)
   //    {
   //       if (i == 2)
   //       {
   //          i++;
   //          continue;
   //       }
   //
   //       if (i == 7)
   //       {
   //          break;
   //       }
   //
   //       if ((i % 2) != 0)
   //       {
   //          Console.WriteLine(i);
   //       }
   //       i++;
   //    }
   //
   //
   //    string guess;
   //
   //    do
   //    {
   //       Console.WriteLine("Guess a Number ");
   //       guess = Console.ReadLine();
   //
   //    } while (guess.Equals("15"));
   //
   //
   //    for (int j = 0; i < 10; j++)
   //    {
   //       if ((j % 2) > 0)
   //       {
   //          Console.WriteLine(i);
   //       }
   //    }
   //
   //
   //    string randString = "Hey Now Everybody";
   //
   //    foreach (char c in randString)
   //    {
   //       Console.WriteLine(c);
   //       /* Infinite
   //          Loop
   //          Here
   //          */
   //    }
   //
   // }

   // public static void Main()
   // {
   //    string sampString = " A bunch of words";
   //
   //    Console.WriteLine("Is empty? " + String.IsNullOrEmpty(sampString));
   //
   //    Console.WriteLine("Is empty? " + String.IsNullOrWhiteSpace(sampString));
   //
   //    Console.WriteLine("String Length = " + sampString.Length);
   //
   //    Console.WriteLine("Index of \"of\" " + sampString.IndexOf("of"));
   //
   //    Console.WriteLine("Second word " + sampString.Substring(2, 6));
   //
   //    string sampString2 = "A bunch more random words";
   //
   //    Console.WriteLine("Starts with \"A bunch\" " + sampString2.StartsWith("A bunch"));
   //
   //    Console.WriteLine("Ends with \"words\" " + sampString2.EndsWith("words"));
   //
   //    sampString = sampString.TrimEnd();
   //
   //    Console.WriteLine(sampString);
   //
   //    sampString = sampString.Replace("words", "characters");
   //
   //    Console.WriteLine(sampString);
   //
   //    sampString = sampString.Remove(0, 3);
   //
   //    Console.WriteLine(sampString);
   //
   //    string[] names = new string[3] {"Matt", "Joe", "Paul"};
   //
   //    Console.WriteLine("Name List: " + String.Join(", ", names));
   //
   //    string formatString = String.Format("{0:c} {1:00} {2:#.00} {3:0.0}", 1.56, 15.567, .56, 1000);
   //
   //    Console.WriteLine(formatString);


   // public static void Main()
   // {
      // StringBuilder sb = new StringBuilder();
      //
      // sb.Append("This is my first sentence. ");
      // sb.AppendFormat("My name is {0} and I am a {1} ", "Tony", "Programmer");
      // sb.Replace("a", "e");
      // sb.Remove(5, 7);
      // Console.WriteLine(sb.ToString());

      // int[] randNumArray;
      //
      // int[] myRandArray = new int[5];
      //
      // int[] myRandArray2 = {1, 2, 3, 4, 5};
      //
      // Console.WriteLine("Array length " + myRandArray2.Length);
      //
      // Console.WriteLine("Item 0 " + myRandArray2[0]);
      //
      // for ( int i = 0; i < myRandArray2.Length; i++)
      // {
      //    Console.WriteLine("{0} : {1}", i, myRandArray2[i]);
      // }
      //
      // foreach(int num in myRandArray2)
      // {
      //    Console.WriteLine(num);
      // }
      //
      // Console.WriteLine("Where is 3? " + Array.IndexOf(myRandArray2, 3));
      //
      // string[] names = {"Tony", "Terence", "Tarpley"};
      //
      // string nameStr = string.Join( ", ", names);
      //
      // string[] nameArray = nameStr.Split(',');
      //
      // Console.WriteLine(nameStr);

      // int[,] multArray = new int[1, 3];
      //
      // int[,] multArray2 = {{0, 2}, {4, 35}, {8, 10}};
      //
      // foreach(int num in multArray)
      // {
      //    Console.WriteLine(num);
      // }
      //
      // for(int x = 0; x < multArray2.GetLength(0); x++)
      // {
      //    for(int y = 0; y < multArray2.GetLength(1); y++)
      //    {
      //       Console.WriteLine("{0} | {1} : {2}", x,y,multArray2[x,y]);
      //    }
      // }
   // }

   // public static void Main()
   // {
   //    List<int> numList = new List<int>();
   //
   //
   //    numList.Add(5);
   //    numList.Add(15);
   //    numList.Add(25);
   //
   //    int[] randArray = {1, 2, 3, 4, 5};
   //    numList.AddRange(randArray);
   //
   //    List<int> numList2 = new List<int>(randArray);
   //
   //    List<int> numList3 = new List<int>(new int[] {1, 2, 3, 4});
   //
   //    numList.Insert(1, 10);
   //
   //    numList.Remove(5);
   //
   //    numList.RemoveAt(2);
   //
   //    for (int i = 0; i < numList.Count; i++)
   //    {
   //       Console.WriteLine(numList[i]);
   //    }
   //
   //    Console.WriteLine("4 is in index: " + numList3.IndexOf(4));
   //
   //    Console.WriteLine("5 in List? " + numList.Contains(5));
   //
   //    List<string> strList = new List<string>(new string[]{"Tony", "Terence"});
   //
   //    Console.WriteLine("Tony in list? " + strList.Contains("Tony"));
   //
   //    strList.Sort();
   // }

   // public static void Main()
   // {
   //    try
   //    {
   //       Console.Write("Divide 10 by ");
   //       int num = int.Parse(Console.ReadLine());
   //       Console.WriteLine("10 / {0} = {1}", num, (10/num));
   //    }
   //
   //    catch(DivideByZeroException ex)
   //    {
   //       Console.WriteLine("Can't divide by zero");
   //       Console.WriteLine(ex.GetType().Name);
   //       Console.WriteLine(ex.Message);
   //       // throw new InvalidOperationException("Operation Failed", ex);
   //    }
   //
   //    catch(Exception ex)
   //    {
   //       Console.WriteLine(ex.GetType().Name);
   //       Console.WriteLine(ex.Message);
   //    }
   // }

   class Animal
   {
         public double height { get; set;}
         public double weight { get; set;}
         public string sound { get; set;}

         public string name;
         public string Name
         {
            get{return name;}
            set{name = value;}
         }

         public Animal()
         {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
         }

         public Animal(double height, double weight, string name, string sound)
         {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
         }

         static int numOfAnimals = 0;

         public static int getNumOfAnimals()
         {
            return numOfAnimals;
         }

         public string toString()
         {
            return String.Format("{0} is {1} inches tall, weighs {2}lbs and likes to say {3}", name, height, weight, sound);
         }

         public int getSum(int num1 = 1, int num2 = 1)
         {
            return num1 + num2;
         }

         public double getSum(double num1 = 1, double num2 = 1)
         {
            return num1 + num2;
         }

         public static void Main()
         {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(num2: 1.4, num1: 2.7));

            Animal rover = new Animal
            {
               name = "Grover",
               height = 16,
               weight = 18,
               sound = "Grrrr"
            };

            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Spike", "Roar", "Chicken");

            Console.WriteLine(spike.toString());

            Shape rect = new Rectangle(5, 5);
            Shape tri = new Rectangle(5, 5);

            Console.WriteLine("Rect Area " + rect.area());
            Console.WriteLine("Tri Area " + tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect Area " + combRect.area());

         }

      }

      class Dog:Animal
      {
         public string favFood{get;set;}

         public Dog() : base()
         {
            this.favFood = "No Favorite Food";
         }

         public Dog(double height, double weight, string name, string sound, string favFood) : base (height, weight, name, sound)
         {
            this.favFood = favFood;
         }

         new public string toString()
         {
            return String.Format("{0} is {1} inches tall, weighs {2}lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
         }
      }



}
