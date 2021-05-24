using System;

namespace System_object
{
	class Program
	{
		static void Main(string[] args)
		{
			//Object is parent of any data type.
			#region Object as data type
			object num = 1;
			Console.WriteLine($"Number :{num}");
			//num refuse the operation in numerical data type like num++ so we must change int int
			int num1 = (int)num;
			num1++;
			num = num1;
			Console.WriteLine($"Number after increasing :{num}");
			#endregion
		}
	}
}
