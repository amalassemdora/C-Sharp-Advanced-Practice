using System;

namespace Mathematical_Calculations
{
class Calc
	{
		#region Properities
		public double number1 { get; set; }
		public double number2 { get; set; }
		#endregion

		#region Ctors
		public Calc(double _number1, double _number2)
		{
			number1 = _number1;
			number2 = _number2;
		}
		#endregion
		#region Methods
		public static  double Sum(double n1, double n2)
		{
			return n1 + n2;
		}
		public static double Sub(double n1, double n2)
		{
			return n1 - n2;
		}
		public static double Mul(double n1, double n2)
		{
			return n1 * n2;
		}
		public static double Div(double n1, double n2)
		{
			return n1 / n2;	
		}
		public static double Mod(double n1, double n2)
		{
			return n1 % n2;
		}
		#endregion

	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***************Enter Numbers***************");
			Console.Write("Enter the first number: ");
			double num1 = double.Parse( Console.ReadLine());
			Console.Write("Enter the second number: ");
			double num2 = double.Parse(Console.ReadLine());
			#region calculation ====>calling function without creating an object
			Console.WriteLine("\n***************Numbers***************");
			Console.WriteLine($"\tNumber1 : {num1}\n\tNumber2 : {num2}");

			Console.WriteLine("\n***************Summution***************");
			Console.WriteLine($"\t{num1} + {num2} = {Calc.Sum(num1,num2)}");

			Console.WriteLine("\n***************Subtraction***************");
			Console.WriteLine($"\t{num1} - {num2} = {Calc.Sub(num1, num2)}");

			Console.WriteLine("\n***************Multiplcation***************");
			Console.WriteLine($"\t{num1} * {num2} = {Calc.Mul(num1, num2)}");

			Console.WriteLine("\n***************Divition***************");
			if (num2 == 0)
			{
			Console.WriteLine("Can't divide by zero");
			}
			else
			{ 
			Console.WriteLine($"\t{num1} / {num2} = {Calc.Div(num1, num2)}");
			}
			Console.WriteLine("\n***************Remender***************");
			if (num2 == 0)
			{
				Console.WriteLine("Can't divide by zero");
			}
			else
			{
				Console.WriteLine($"\t{num1} % {num2} = {Calc.Mod(num1, num2)}");
			}
			#endregion
			Console.ReadKey();
		}
	}
}
