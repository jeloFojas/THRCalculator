using System;

namespace THRCalculator
{
	/// <summary>
	/// The main program that calculates the Average RHR, MHR, and displays the Target Heart Rate.
	/// </summary>
	/// <author>Noahangelo Cappal</author>
	internal class Program
	{
		/// <summary>
		/// Entry point of the program.
		/// </summary>
		/// <param name="args">Command-line arguments (not used).</param>
		static void Main(string[] args)
		{
			int[] rhrValues = THRUtilities.GetRHRValues();
			int timesChecked = THRUtilities.GetTimesChecked();
			double averageRHR = THRUtilities.CalculateAverageRHR(rhrValues, timesChecked);

			Console.WriteLine($"\nAverage RHR: {averageRHR} BPM");
			Console.WriteLine("=========================================");

			int age = THRUtilities.GetUserAge();
			int mhr = THRUtilities.CalculateMHR(age);

			Console.WriteLine($"MHR: {mhr}");
			Console.WriteLine("=========================================");

			THRUtilities.DisplayTHRResults(mhr, averageRHR);

			Console.WriteLine("Made by Noahangelo Cappal");
		}
	}
}
