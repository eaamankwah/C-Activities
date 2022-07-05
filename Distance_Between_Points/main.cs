using System;
/**
*
*
Write a program that calculates the distance of 2 points from the origin, as well as from each other. The distance between 2 points can be calculated using the formula:
https://www.mathsisfun.com/algebra/distance-2-points.html
https://www.youtube.com/watch?v=CWUr6Jo6tag

Read the coordinates of 2 2D points from the user. A point is represented by its x, y coordinates.
Calculate and print the distance of the first point from the origin, (0, 0).
Calculate and print the distance of the second point from the origin.
Calculate and print the distance between the two points.
*/

class Program 
{
    public static void Main (string[] args) 
    {
    //read in 2 points from the user by having them input 4 values
    double x1, x2, y1, y2;//have code to read these all in
 
    //make a function here to calculate the distance from two points
    Console.WriteLine("Enter the first point value, x1: ");
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the first point value, y1: ");
    y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second point value, x2: ");
    x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second value, y2: ");
    y2 = double.Parse(Console.ReadLine());

    Console.WriteLine("The distance of first point (x1, y1) from origin (0,0): " +
                    Math.Sqrt(Math.Pow(x1-0,2) + Math.Pow(y1-0,2)) + "\n" + "\n" +
                    "Ther distance of second point (x2, y2) from origin (0,0): " +
                    Math.Sqrt(Math.Pow(x2-0,2) + Math.Pow(y2-0,2)) + "\n" + "\n" +
                    "The distance between the two points (x1, x2) and (y1 and y2): " + 
                    DistFirstSecondPoint(x1,x2,y1,y2));
    Console.ReadLine(); 
    }

    // calculates the distance of 2 points from the origin, as well as from each other
    static double DistFirstSecondPoint(double x1, double x2, double y1, double y2)
    {
    double firstSecond = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
    return firstSecond;
    }
}
