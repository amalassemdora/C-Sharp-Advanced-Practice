using System;

namespace Value_Reference_Type
{
	public class Student
	{
		#region proprities
		public int id { get; set; }
		public string name { get; set; }
		#endregion

		#region constructors
		public Student(int _id,string _name)
		{
			id = _id;
			name = _name;
		}
		#endregion
		#region Methods
		public string Print()
		{
			return $"Student_ID : {id} Student_Name : {name}";
		}
		#endregion
	}
	class Program
	{
		static void Main(string[] args)
		{
			#region Value Type
			Console.WriteLine("***********Value type***********");
			int num1 = 5;
			int num2 = 8;
			Console.WriteLine($"\nIn begining : Number1 = {num1}  &  Number2 = {num2}");
			num1 = num2;
			num2 = 12;
			Console.WriteLine($"\nAfter assignment : Number1 = {num1}  &  Number2 = {num2}");
			//using new keyword with value type that make initialize the operand with its defult value 
			int num3 = new int();
			//defult value of int datatype is 0
			Console.WriteLine($"\nUsing new keyword with value type : Number3 = {num3}");
			#endregion

			#region Reference type
			Console.WriteLine("\n\n***********Reference type***********");
			Student s1 = new Student(8,"Amal Assem");
			Student s2 = new Student(5, "Fatma Assem");
			Console.WriteLine($"\nIn begining : \n\tStudent1 :{s1.Print()}\n\tStudent2 :{s2.Print()}");
			s1 = s2;
			Console.WriteLine($"\nAfter Assignment s2 to s1 : \n\tStudent1 :{s1.Print()}\n\tStudent2 :{s2.Print()}");
			s2.id = 10;
			s2.name="Amany Assem";
			Console.WriteLine($"\nAfter changing the value of s2 : \n\tStudent1 :{s1.Print()}\n\tStudent2 :{s2.Print()}");
			#endregion
			Console.ReadKey();
		}
	}
}
