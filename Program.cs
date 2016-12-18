//creating multiple instances of a class, which have their own member function() and variables.
using System;  // C# Object Orientated Programming two boxes area maths.
namespace TwoBoxAreaMaths
{
	class Box  //Object Box, with return area maths method. 
	{
		public double l,w,h; //set the variables. Public member access modifier.
		public double volume() //method.
		{
			return (this.l*this.w*this.h); //this objects variables.
		}
	}		
	class Program //Build new Object Box1, asign values and write volume.
	{
		public static void Main(string []args)
		{
			//instance of a Box class:
			Box Box1 = new Box(); //class, object, =new class method, builds the new object.			
			Box1.l = 10; //new object Box1's length, asigning a new value to it.			
			Box1.w = 10; //new object Box1's width, asigning a new value to it.			
			Box1.h = 10; //new object Box1's height, asigning a new value to it.			
			Console.WriteLine("The volume of Mike's C# Box1 is: {0}",Box1.volume()); //write to screen
			
			//instance of a Box class:
			Box Box2 = new Box(); //class, object, =new class method, builds the new object.			
			Box2.l = 20; //new object Box1's length, asigning a new value to it.			
			Box2.w = 20; //new object Box1's width, asigning a new value to it.			
			Box2.h = 20; //new object Box1's height, asigning a new value to it.			
			Console.WriteLine("\nThe volume of Mike's C# Box2 is: {0}",Box2.volume()); //write to screen
			Console.ReadKey(true); 
		}
	}
}