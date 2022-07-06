using System;


/*
Learning Activity 2: Quadratic Equations

Write a program to calculate the roots of a quadratic equation. A quadratic equation is an equation of the form:

			ax^2+bx+c=0

The roots of a quadratic equation are given by the formula:

			x=(-b±√(b^2-4ac))/2a
      
*/
class Program {
  public static void Main (string[] args) {
    int a, b, c;

    double discriminant, x1, x2;
      Console.WriteLine("Compute root of quadratic equation: \n");
      Console.WriteLine("Enter the value of a: ");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the value of b: ");
      b = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the value of c: ");
      c = int.Parse(Console.ReadLine());
      
    discriminant = Math.Pow(b,2) - (4*a*c);
      if(discriminant == 0)
      {
      Console.WriteLine("Both roots are equal.\n");
      x1 = -b/(2.0*a);
      x2 = x1;
      Console.WriteLine("Root1= {0}\n",x1);
      Console.WriteLine("Root2= {0}\n",x2);
      }
     else if(discriminant > 0)
	    {
	   Console.WriteLine("Both roots are real \n");

	    x1 = (-b + Math.Sqrt(discriminant))/(2*a);
	    x2 = (-b - Math.Sqrt(discriminant))/(2*a);

	   Console.WriteLine("Root1 = {0}\n",x1);
	   Console.WriteLine("Root2 = {0}\n",x2);
	   }
	  else
	    Console.WriteLine("Roots are imaginary;\nNo Real Solution. \n\n");
    //Console.WriteLine ("Hello World");
  }
}