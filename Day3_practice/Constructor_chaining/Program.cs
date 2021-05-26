using System;

namespace Constructor_chaining
{
	//class student
	class Student
	{
		#region variables
		public static int count;
		#endregion

		#region Properities
		public int id{ get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public string address { get; set; }
		#endregion

		#region constructor
		static Student()
		{
			count=0;
		}
		public Student()
		{

		}
		public Student(int id,string name)
		{
			count++;
			this.id = id;
			this.name = name;
		}
		public Student(int id, string name,int age):this(id,name)
		{
			this.age = age;
		}
		public Student(int id, string name, int age,string address) : this(id, name,age)
		{
			this.address = address;
		}

		#endregion
		#region Methods
		public override string ToString()
		{
			return $"ID : {id},\t  Name : {name},\t Age : {age},\t Address : {address}";
		}
		public static bool operator == (Student s1,Student s2)
		{
			return (s1.id==s2.id && s1.name==s2.name && s1.age==s2.age&&s1.address==s2.address);
		}
		public static bool operator !=(Student s1, Student s2)
		{
			return (s1.id == s2.id || s1.name == s2.name || s1.age == s2.age || s1.address == s2.address);
		}
		public static Student operator + (Student s1, Student s2)
		{
			Student s = new Student();
			s.id = s1.id + s2.id;
			s.name = s1.name +" "+ s2.name;
			s.age = s1.age + s2.age;
			s.address = s1.address;
			return s;
		}
		#endregion
	}
	class Program
	{
		static void Main(string[] args)
		{
			
			Student s1 = new Student(1, "Amal",10,"Cairo");
			Student s2 = new Student(2, "Assem",15,"Alex");

			Console.WriteLine("\n*****************Data*****************");
			Console.WriteLine($"Student1 : {s1}");
			Console.WriteLine($"Student2 : {s2}");

			Console.WriteLine("\n***************** == *****************");
			if (s1 == s2)
			{
				Console.WriteLine("The data of two students are the same");
			}
			else
			{
				Console.WriteLine("\nThe data of two students are different");

			}

			Console.WriteLine("\n***************** != *****************");
			if (s1 != s2)
			{
				Console.WriteLine("The data of two students are different");
			}
			else
			{
				Console.WriteLine("The data of two students are the same");

			}

			Console.WriteLine("\n***************** + *****************");
			Console.WriteLine(s1+s2);

			Console.WriteLine("\n***************** The number of students *****************");
			Console.WriteLine($"# students : {Student.count}");
			Console.ReadKey();
		}
	}
}
