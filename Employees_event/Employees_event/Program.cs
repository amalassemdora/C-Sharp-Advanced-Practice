using System;

namespace Employees_event
{
	public delegate void mydel(Employee emp);
	public class Employee
	{
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public static event mydel AddMember;
		public static event mydel RemoveMember;
		public Employee(int id = 1, string name = " ", int age = 20)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			AddMember += Club.AddMembers;
			if (this.age >= 60)
			{
				RemoveMember += SocialInsurance.RemoveMembers;
				AddMember(this);
				RemoveMember(this);
			}
			else
			{
				AddMember += SocialInsurance.AddMembers;
				AddMember(this);
			}
			AddMember = null;
			RemoveMember = null;
		}
		public override string ToString()
		{
			return $"{id}\t{name}\t{age}";

		}
	}
	public class Club
	{
		 Club()
		{
		}
		public static void AddMembers(Employee emp)
		{
			Console.WriteLine($"Hello! {emp.name}\n* you are a club member");
		}
	}
	public class SocialInsurance
	{
		public static void AddMembers(Employee emp)
		{
			Console.WriteLine($"*you have Social Insurance");
			Console.WriteLine("****************************************************");
		}
		public static void RemoveMembers(Employee emp)
		{
			Console.WriteLine("*you are retired,you have not Social Insurance");
			Console.WriteLine("****************************************************");

		}
	}
		class Program
	{
		static void Main(string[] args)
		{
		    Employee emp2 = new Employee(1, "ali", 61);
			Employee emp1 = new Employee(1,"amal",25);
			Employee emp4 = new Employee(1, "amany", 65);
			Employee emp3 = new Employee(1, "fatma", 22);

			Console.ReadKey();
		}
	}
}
