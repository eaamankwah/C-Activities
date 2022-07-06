using System;
/**
*
You are a software developer. You are developing software for a shopping mall. The mall usually greets every customer with a person-specific greeting message. You figured out that there are redundant codes that can be eliminated, and the program could be optimized with fewer instructions for producing the same output. As a challenge, modify the program and remove all redundant code!
*/
class Program 
{
		public static void GreetCustomer( string name)
		{
			Console.WriteLine("Hi " + name + "!" + "\n" + "Thank you very much for shopping with us." + "\n"
                       + "Our shop usually keeps special offers for customers like you; " +  name + "\n" 
                       + "So " + name + ", do you want to explore your offer?"
                       );
    }
		static void Main(string[] args)
		{
      Console.WriteLine();
      //str1 = Console.ReadLine();
      GreetCustomer("Alex");
      Console.WriteLine();
      GreetCustomer("Susan");
      Console.WriteLine();
      GreetCustomer("Ken");
			Console.ReadLine();
		}
}
