using System;

public enum Colors {Blue = 1, Red = 2, Green = 3, Yellow = 5, Cyan = 7, Magenta = 9}

class Program {
  static void Main() {
      
       bool primeNumber;
       int outputCount = 0;
      
      Console.WriteLine("Here are prime numbers from 1 - 101: ");
      Console.WriteLine("******************");
     
      for (int i = 2; i < 101; i++ )
      {
          //reset count for 5 to make rows of 5
          if (outputCount == 5)
          {
              Console.WriteLine();
              outputCount = 0;
          }
          
          //send i to test if its prime
         primeNumber = primeTest(i);
         
         //if its prime, change the color accordingly and output
         if (primeNumber)
         {
             changeColor(i);
             Console.Write(" " + $"{i, 5}" + "  ");
             Console.ResetColor();
             outputCount++;
         }
      }
  }
      public static void changeColor(int num)
    {
        //mod by 10 to get ones place
     int onesPlace = num % 10;    
     Colors color = (Colors)onesPlace;
     
      switch (color)
      {
          case Colors.Blue: Console.BackgroundColor = ConsoleColor.Blue;
          break;
          case Colors.Red: Console.BackgroundColor = ConsoleColor.Red;
          break;
          case Colors.Green: Console.BackgroundColor = ConsoleColor.Green;
          break;
          case Colors.Yellow: Console.BackgroundColor = ConsoleColor.Yellow;
          break;
          case Colors.Cyan: Console.BackgroundColor = ConsoleColor.Cyan;
          break;
          case Colors.Magenta: Console.BackgroundColor = ConsoleColor.Magenta;
          break;
      }
        
    }
  public static bool primeTest(int num)
  {
     bool isPrime = true;
    
    //if num / any number besides 1 and itself is ==0, then it isnt prime
    for(int i = 2; i*i <= num; i++) 
    {
       if (num % i == 0) 
         isPrime = false;
    }
    return isPrime;
  }
}
