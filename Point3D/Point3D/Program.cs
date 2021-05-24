using System;

namespace Point3D
{
	class Program
	{
		public class Point3D
		{
			public int p1 { get; set; }
			public int p2 { get; set; }
			public int p3 { get; set; }
			public Point3D(int _p1,int _p2,int _p3)
			{
				p1 = _p1;
				p2 = _p2;
				p3 = _p3;
			}
			public override string ToString()
			{
				return $"Point Coordinates:  ({p1} ,{p2} ,{p3})";
			}
		}

		static void Main(string[] args)
		{
			Point3D p = new Point3D(10, 10, 10);
			Console.WriteLine(p.ToString());
			Console.ReadKey();
		}
	}
}
