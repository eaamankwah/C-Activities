using System;
/*
*Learning Activity 1: Circle Calculator
Write a program that gets the radius of a circle as input from the user, then calculates the circumference and area of the circle and prints the values to the console.
*
*/
class Program 
{
  public static void Main (string[] args) 
  {
    double pi = 3.142;
    double radius, circumference, area;
    Console.WriteLine ("What is the radius of the circle?");
    radius = Convert.ToDouble(Console.ReadLine());
    
    // Calculate circumference of a circle : 2*pi*r
    circumference = 2 * pi * radius;
    // Area of a circle = pie* r^2
    area = pi * radius * radius;
    Console.WriteLine("Circumference of Circle : " + circumference + " and Area of cirle : "+ area);
    
  }
}