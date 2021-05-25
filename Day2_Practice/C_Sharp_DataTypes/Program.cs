using System;

namespace C_Sharp_DataTypes
{
	struct complex
	{
		public int real { get; set; }
		public int img { get; set; }

		public complex(int _real, int _img)
		{
			real = _real;
			img = _img;
		}
		public complex(int _real)
		{
			real = _real;
			this.img = 0;
		}
		public override string ToString()
		{
			return $"{real}+{img}i";
		}

		public void print()
		{
			Console.WriteLine($"{real}+{img}i");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			#region Nullable type
			//frist way to convert datatype to nullable type
			int? x = null;
			//second way to convert datatype to nullable type
			Nullable<int> y = null;

			bool? st = null;
			#endregion
			#region implicity type local variable
			//var get type after assign value in order to allocate in memory can't be changed after assign
			var v1 = 3;
			var v2 = "Amal";
			#endregion
			#region Dynamic
			//can change data type after assign by delete the first one 
			//can couse boxing & unboxing
			dynamic d1 = 1;
			d1 = "ali";
			d1 = 6;
			#endregion
			#region complex datatype {Struct)
			complex c = new complex();
			Console.WriteLine(c.real);
			complex c1 = new complex(1, 2);
			complex c2 = new complex(1, 2);
			if (c1.Equals(c2))
			{
				Console.WriteLine("true");
			}
			#endregion
			Console.ReadKey();
		}
	}
}
