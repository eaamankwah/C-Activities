using System;
/*
*
*Fix the errors in the following code*
*/

	class Program
	{
		const float PI = 3.14159f;
    static void Main(string[] args)
		{
			int a, b, gamma;
			Console.WriteLine("Enter the length side a: ");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the length of side b: ");
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the angle gamma: ");
			gamma = int.Parse(Console.ReadLine());
			Console.WriteLine("The length of side c is "+ CalcTriangleEdge(a, b, DegreesToRadians(gamma)));
			//return "0";
		}
    // Method to convert degrees to radians
		static float DegreesToRadians(float degrees)
		{
			return degrees * PI / 180.0f;
		}
    // Method to calculate length of the side of the triange
    static float CalcTriangleEdge(float a, float b, float gamma)
		{
		return (float)Math.Sqrt(a * a + b * b - 2 * a * b * (float)Math.Cos(gamma));
		}
	}

