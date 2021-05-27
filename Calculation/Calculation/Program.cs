using System;
using System.IO;
using System.Globalization;


namespace Calculation
{
	class Operation
	{
		#region method
		public static double calc(double num1, double num2, ref double div, out double mul, out double sub)
		{
			double sum;
			sum = num1 + num2;
			sub = num1 - num2;
			mul = num1 * num2;
			div = num1 / num2;
			return sum;
		}
		#endregion
	}
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"E:\ITI\iti\C# Advanced\Day-4\Task\Calculation\logfile.txt";
			string excepout = "There is No Error!\n\n";
			try
			{
				Console.Write("Enter Number 1: ");
				double x = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter Number 2: ");
				double y = Convert.ToDouble(Console.ReadLine());
				double sub_res;
				double mul_res;
				double div_res = 1;
				double sum_res = Operation.calc(x, y, ref div_res, out mul_res, out sub_res);
				Console.WriteLine("**************Summation**************");
				Console.WriteLine($"{x} + {y} = {sum_res}");
				Console.WriteLine("**************Subtraction**************");
				Console.WriteLine($"{x} - {y} = {sub_res}");
				Console.WriteLine("**************Multiplication**************");
				Console.WriteLine($"{x} * {y} = {mul_res}");
				Console.WriteLine("**************Divition**************");
				Console.WriteLine($"{x} / {y} = {div_res}");
				if (y == 0)
				{
					throw new DivideByZeroException();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("There is aproblem please try later");
				excepout = $"Exception type: {e.GetType().Name}\nMessage: {e.Message}\nData: {e.Data.ToString()}\n\n";
				if (e.InnerException != null)
				{
					excepout += e.InnerException.ToString();
				}
			}
			finally
			{
				
				File.AppendAllText(filePath, excepout);
			}
				Console.ReadKey();

			
		}
	}
}


