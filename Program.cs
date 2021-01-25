using System;

namespace D2_Iteratives
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number between 1 and 100...");

			if (int.TryParse(Console.ReadLine(), out int numLoops) && numLoops >= 1 && numLoops <= 100)
				for (int i = 1; i <= numLoops; i++)
					Console.WriteLine($"You have entered {numLoops}. This is the current integer value in the loop: {i}");
			else
				Console.WriteLine("You must enter an integer value between 1 and 100!");
		}
	}
}
