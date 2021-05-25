using System;

namespace Point3D
{
	class Program
	{
		public class Point3D
		{
			#region properties
			public int p1 { get; set; }
			public int p2 { get; set; }
			public int p3 { get; set; }
			#endregion
			#region ctors
			public Point3D() //defult ctor
			{
				p1 = 10;
				p2 = 10;
				p3 = 10;
			}
			public Point3D(int _p1,int _p2,int _p3)
			{
				p1 = _p1;
				p2 = _p2;
				p3 = _p3;
			}
			#endregion

			#region Methods
			public string Print()
			{
				return $"\nPoint Coordinates:  ({p1} ,{p2} ,{p3})";
			}
			public override string ToString()
			{
				return $"\nPoint Coordinates:  ({p1} ,{p2} ,{p3})";
			}
			#endregion
		}

		static void Main(string[] args)
		{
			Console.WriteLine("\n***********Defult constractor***********");
			Point3D p1 = new Point3D();
			Console.WriteLine(p1.ToString());
			Console.WriteLine("\n***********Constractor with three parameter***********");
			Point3D p2 = new Point3D(10, 10, 10);
			Console.WriteLine(p2.ToString());
			Console.ReadKey();
		}
	}
}
