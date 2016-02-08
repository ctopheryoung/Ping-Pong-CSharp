using System;

public class PingPong
{
  public static void Main()
  {
    Console.WriteLine("What's your number?");

    string yourNumberString = Console.ReadLine();
    int yourNumberInt = int.Parse(yourNumberString);

    for (int number = 0; number <= yourNumberInt; number ++)
    {
      if (number % 15 == 0)
      {
        Console.WriteLine("PingPong");
      } else if ( number % 3 == 0)
        {
          Console.WriteLine("Ping");
        } else if (number % 5 == 0)
          {
            Console.WriteLine("Pong");
          } else
            {
              Console.WriteLine(number);
            }
    }
  }
}
