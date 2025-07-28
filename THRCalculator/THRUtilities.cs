using System;

namespace THRCalculator
{
	/// <summary>
	/// A utility class that provides methods to calculate Resting Heart Rate (RHR),
	/// Maximum Heart Rate (MHR), and Target Heart Rate (THR) zones.
	/// </summary>
	/// <author>Noahangelo Cappal</author>
	internal static class THRUtilities
	{
		/// <summary>
		/// Prompts the user to input their Resting Heart Rate (RHR) for each day of the week.
		/// </summary>
		/// <returns>An array of integers representing the RHR values for the week.</returns>
		public static int[] GetRHRValues()
		{
			string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			int[] values = new int[7];

			Console.WriteLine("Input your RHR for each day. Enter 0 if you did not check it.");

			for (int i = 0; i < days.Length; i++)
			{
				Console.Write($"{days[i]}: ");
				values[i] = Convert.ToInt32(Console.ReadLine());
			}

			return values;
		}

		/// <summary>
		/// Prompts the user to input how many times they checked their RHR in the week.
		/// </summary>
		/// <returns>An integer representing the number of times RHR was checked.</returns>
		public static int GetTimesChecked()
		{
			Console.Write("How many times did you check your RHR? ");
			return Convert.ToInt32(Console.ReadLine());
		}

		/// <summary>
		/// Calculates the average RHR from the input values and the number of times checked.
		/// </summary>
		/// <param name="values">An array of RHR values.</param>
		/// <param name="times">The number of times RHR was checked.</param>
		/// <returns>The average RHR as a double.</returns>
		public static double CalculateAverageRHR(int[] values, int times)
		{
			int total = 0;
			foreach (int value in values)
			{
				total += value;
			}

			return times > 0 ? (double)total / times : 0;
		}

		/// <summary>
		/// Prompts the user to enter their age.
		/// </summary>
		/// <returns>An integer representing the user's age.</returns>
		public static int GetUserAge()
		{
			Console.Write("Your age: ");
			return Convert.ToInt32(Console.ReadLine());
		}

		/// <summary>
		/// Calculates the Maximum Heart Rate (MHR) using the standard formula.
		/// </summary>
		/// <param name="age">The age of the user.</param>
		/// <returns>The MHR as an integer.</returns>
		public static int CalculateMHR(int age)
		{
			return 220 - age;
		}

		/// <summary>
		/// Calculates and displays the Target Heart Rate (THR) zones: Low, Moderate, and High Intensity.
		/// </summary>
		/// <param name="mhr">The Maximum Heart Rate.</param>
		/// <param name="averageRHR">The average Resting Heart Rate.</param>
		public static void DisplayTHRResults(int mhr, double averageRHR)
		{
			double low = (mhr - averageRHR) * 0.5 + averageRHR;
			double moderate = (mhr - averageRHR) * 0.7 + averageRHR;
			double high = (mhr - averageRHR) * 0.9 + averageRHR;

			Console.WriteLine("The Result Of Your THR is:");
			Console.WriteLine($"Low Intensity: {low}");
			Console.WriteLine($"Moderate Intensity: {moderate}");
			Console.WriteLine($"High Intensity: {high}");
		}
	}
}
