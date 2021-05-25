using System;

namespace System_object
{

	public class Student
	{
		#region proprities
		public int id { get; set; }
		public string name { get; set; }
		#endregion

		#region constructors
		public Student(int _id, string _name)
		{
			id = _id;
			name = _name;
		}
		#endregion
		#region Methods
		//override system .object method(ToString(), Equals() ,GetHashCode())
		public override string ToString()
		{
			return $"Student_ID : {id} Student_Name : {name}";
		}
		public override bool Equals(object obj)
		{
			Student s2 = (Student)obj;

			return (id==s2.id && name==s2.name);
		}
		public override int GetHashCode()
		{
			return id;
		}
		public string Print()
		{
			return $"Student_ID : {id} Student_Name : {name}";
		}
		#endregion
	}
	public class parent
	{
		#region proprities
		public int x { get; set; }
		#endregion

		#region Methods
		public void show()
		{
			Console.WriteLine($"X :{x}");
		}
		#endregion
	}
	public class Child:parent
	{
		#region proprities
		public int y { get; set; }
		#endregion

		#region Methods
		public void show()
		{
			Console.WriteLine($"X :{x} & Y : {y}");
		}
		#endregion

	}
	class Program
	{
		static void Main(string[] args)
		{
			//Object is parent of any data type.is a reference type
			#region Object as data type
			object num = 1;
			Console.WriteLine($"Number :{num}");
			//num refuse the operation in numerical data type like num++ so we must change int int
			int num1 = (int)num;
			num1++;
			num = num1;
			Console.WriteLine($"Number after increasing :{num}");
			#endregion
			//Converting from value type to reference type called (Boxing)=====>Implecitly
			Console.WriteLine("***************Boxing***************");
			int x = 5; //stack
			object obj = x;//heap
			Console.WriteLine($"Value type : {x} converted to reference type : {obj}");

			//Converting from reference type to value type  called (unBoxing)=====>explecitly
			Console.WriteLine("***************unBoxing***************");
			object obj1 = 3;//heap
			int y =(int) obj1; //stack
			
			Console.WriteLine($"Value type : {x} converted to reference type : {obj}");

			///////////////////***********************************/////////////////////////////////////
			#region MyRegion
			Student s = new Student(1, "Amal");
			//use override tostring()
			Console.WriteLine("***************ToString()***************");
			Console.WriteLine(s.ToString());
			//use override Equals()
			Console.WriteLine("***************Equals()***************");
			Student S = new Student(1, "fatma");
			Student S2 = new Student(1, "fatma");
			if (S.Equals(S2))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
			#endregion
			#region intance of parent and child class
			parent p = new Child();
			//p show method show in child but can't access it
			p.show();     //it is show() in parent class
			Console.WriteLine("***************GetType()***************");

			Child c = new Child();
			Console.WriteLine(c.GetType());
			#endregion
			Console.ReadKey();
		}
	}
}
