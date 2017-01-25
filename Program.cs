using System;

namespace Greeting
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var firstName = Console.ReadLine();
			var lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
		}
	}
}
