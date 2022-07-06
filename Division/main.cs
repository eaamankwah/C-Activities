using System;
//The following program is syntactically correct, however, it is producing incorrect result. Identify the problem and correct the program.

class Program {
  public static float Divide(float m, float n)
  {
    return  m / n;
  }
  static void Main(string[] args)
  {
    double result = Divide(17, 5);
    Console.WriteLine(result);
    Console.ReadLine();
  }
}