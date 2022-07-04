using System;


/*
Learning Activity: Hello Name

Write a program that asks the user to enter their name, then prints a greeting using their name.
1.	Print the following message: “What is your name?”
2.	Read the name the user enters.
3.	Print the following message: “What is your age?”
4.	Read the user’s age as an integer.
5.	Print a greeting in the following format: “Hello NAME (AGE)!”. Replace NAME and AGE with the values retrieved from the user.

*/
class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("What is your name? ");
    string name = Console.ReadLine();
    Console.WriteLine("What is your age? ");
    string age = Console.ReadLine();
    int ageInt  = int.Parse(age);
    Console.WriteLine("Hello, " + name + "(" + ageInt +")");
  }
}