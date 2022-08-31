using System;
class HelloWorld
{
  static void Main ()
  {
    Console.Write ("Enter a number: ");
    int n = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine("Square: " + n*n);
  }
}

