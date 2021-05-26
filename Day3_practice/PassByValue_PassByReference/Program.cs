using System;

namespace PassByValue_PassByReference
{
	class student
	{
		#region Properities
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public string address { get; set; }
		#endregion

		#region constructor

		public student(int id, string name)
		{
			this.id = id;
			this.name = name;
		}
		#endregion
		#region Methods
		public override string ToString()
		{
			return $"ID : {id},    Name : {name}";
		}
		#endregion
	}
	class Operation
	    {
		#region Pass by value
		//pass value type by value
		public static void Swap(int num1, int num2)
		{
			int temp = num1;
			num1 = num2;
			num2 = temp;
		}
		//pass Reference type by value
		public static void Swap(student s1, student s2)
		{
			student s = s1;
			s1 = s2;
			s2 = s;
		}

		#endregion
		#region Pass by value
		//pass value type by Reference
		public static void Swap(ref int num1, ref int num2)
		{
			int temp = num1;
			num1 = num2;
			num2 = temp;
		}
		//pass Reference type by Reference
		public static void Swap(ref student s1, ref student s2)
		{
			student s = s1;
			s1 = s2;
			s2 = s;
		}

		#endregion

	}
	class Program
	{
		static void Main(string[] args)
		{
			//Value type
			int n1 = 5, n2 = 9;
			//Reference type
			student s1 = new student(1, "Amal");
			student s2 = new student(2, "Assem");
			
			//pass value type by value
			Console.WriteLine("Before Swapping value type by value:");
			Console.WriteLine($"Number1 = {n1}\tNumber2 = {n2}");
			Operation.Swap(n1, n2);
			Console.WriteLine("\nAfter Swapping value type by value:");
			Console.WriteLine($"Number1 = {n1}\tNumber2 = {n2}");

			//pass value type by reference
			Console.WriteLine("\nBefore Swapping value type by reference:");
			Console.WriteLine($"Number1 = {n1}\tNumber2 = {n2}");
			Operation.Swap(ref n1, ref n2);
			Console.WriteLine("\nAfter Swapping value type by reference:");
			Console.WriteLine($"Number1 = {n1}\tNumber2 = {n2}");

			//pass reference type by value
			Console.WriteLine("\nBefore Swapping value type by value:");
			Console.WriteLine($"Student1 : {s1}\nStudent2 : {s2}");
			Operation.Swap(s1, s2);
			Console.WriteLine("\nAfter Swapping value type by value:");
			Console.WriteLine($"Student2 : {s1}\nStudent2 : {s2}");

			//pass reference type by reference
			Console.WriteLine("\nBefore Swapping value type by reference:");
			Console.WriteLine($"Student1 : {s1}\nStudent2 : {s2}");
			Operation.Swap(ref s1, ref s2);
			Console.WriteLine("\nAfter Swapping value type by reference:");
			Console.WriteLine($"Student2 : {s1}\nStudent2 : {s2}");

			Console.ReadKey();
		}
	}
}
