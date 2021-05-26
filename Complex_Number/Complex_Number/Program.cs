using System;
namespace Complex_Number
{
	class Complex
	{
		public int real { get; set; }
		public int img { get; set; }
		public Complex()
		{

		}
		public Complex(int _real,int _img)
		{
			real = _real;
			img = _img;

		}
		public override string ToString()
		{
			return $"{real}+{img}i";
		}
		public override bool Equals(object obj)
		{
			Complex c = (Complex)obj;
			return (real == c.real && img == c.img);
		}
		public static bool operator == (Complex c1, Complex c2)
		{
			return (c1.real == c2.real && c1.img == c2.img);
		}
		public static bool operator != (Complex c1, Complex c2)
		{
			return (c1.real != c2.real || c1.img != c2.img);
		}
		public static Complex operator + (Complex c1, Complex c2)
		{
			Complex c = new Complex(); 
			c.real= c1.real + c2.real;
			c.img = c1.img + c2.img;
			return c;
		}
		public static Complex operator - (Complex c1, Complex c2)
		{
			Complex c = new Complex();
			c.real = c1.real - c2.real;
			c.img = c1.img - c2.img;
			return c;
		}
		public static bool operator > (Complex c1, Complex c2)
		{
			if (c1.real > c2.real) {
				return true;
			}else if (c1.real == c2.real&& c1.img > c2.img)
			{
				return true;
			}else
			{
				return false;
			}
		}
		public static bool operator < (Complex c1, Complex c2)
		{
			if (c1.real < c2.real)
			{
				return true;
			}
			else if (c1.real == c2.real && c1.img < c2.img)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


	}
	class Program
	{
		static void Main(string[] args)
		{
			Complex c1 = new Complex(5, 2);
			Complex c2 = new Complex(10, 2);

			Console.WriteLine("\n************To String************");
			Console.WriteLine($"\tNum1 {c1.ToString()}");
		    Console.WriteLine($"\tNum1 {c2.ToString()}");

			Console.WriteLine("\n************ Equals ************");
			if (c1.Equals(c2))
			{
				Console.WriteLine($"\t{c1.ToString()} equal {c2.ToString()}");
			}
			else
			{
				Console.WriteLine($"\t{c1.ToString()} Not equal {c2.ToString()}");
			}

			Console.WriteLine("\n************ == ************");
			if (c1 == c2)
			{
				Console.WriteLine($"\t{c1.ToString()} equal {c2.ToString()}");
			}
			else
			{
				Console.WriteLine($"\t{c1.ToString()} Not equal {c2.ToString()}");
			}

			Console.WriteLine("\n************ != ************");
			if (c1 != c2)
			{
				Console.WriteLine($"\t{c1.ToString()} Not equal {c2.ToString()}");
			}
			else
			{
				Console.WriteLine($"\t{c1.ToString()} equal {c2.ToString()}");
			}

			Console.WriteLine("\n************ + ************");
			Console.WriteLine($"\t{c1.ToString()} + {c2.ToString()} = {c1+c2}");

			Console.WriteLine("\n************ - ************");
			Console.WriteLine($"\t{c1.ToString()} - {c2.ToString()} = {c1 - c2}");
			Console.ReadKey();
		}
	}
}
