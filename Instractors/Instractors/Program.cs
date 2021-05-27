using System;
using System.IO;
namespace Instractors
{
	abstract class Instractor
	{
		#region props
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public decimal salary { get; set; }
		#endregion
		#region ctor by initialize parameter with defult value
		public Instractor(int id, string name="", int age=20, decimal salary=10000)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.salary = salary;
		}
		#endregion
		#region abstract method
		public abstract void register();
		public abstract void show();
		#endregion
	}
	class TechInstractor:Instractor
	{
		#region prop
		public string[] subjects {get; set; }
		#endregion
		#region ctor
		public TechInstractor(int id, string name, int age, decimal salary, params string[] subjects):base(id,name,age,salary)
		{
			this.subjects = subjects;
		}
		#endregion
		#region implementation abstact methods
		public override void show()
		{

			Console.WriteLine($"Instructor Data : \nID: {id}\nName: {name}\nAge: {age}\nSalary: {salary}");
			Console.Write("Subjects: ");
			for (int i = 0; i < subjects.Length; i++)
			{
				Console.Write(subjects[i] + "   ");
			}
			Console.WriteLine();
		}
		public override void register()
		{
			Console.WriteLine($"Technical Instructor '{name}' Registered.");
		}
		#endregion
	}
	class SoftSkillsInstractor:Instractor
	{
		#region prop
		public int Num_Certificats { get; set; }
		#endregion
		#region ctor
		public SoftSkillsInstractor(int id, string name, int age, decimal salary,int Num_Certificats):base(id, name, age, salary)
		{
			this.Num_Certificats = Num_Certificats;
		}
		#endregion
		#region implementation abstact methods
		public override void show()
		{
			Console.WriteLine($"Instructor Data : \nID: {id}\nName: {name}\nAge: {age}\nSalary: {salary}\nNumber of Certificats: {Num_Certificats}");		
		}
		public override void register()
		{
			Console.WriteLine($"SoftSkills Instructor '{name}' Registered.");
		}
#endregion
	}
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"E:\ITI\iti\C# Advanced\Day-4\Task\Calculation\logfile.txt";
			string excepout = "There is No Error!";
			try
			{
				TechInstractor tech1 = new TechInstractor(1, "Amal Assem", 25, 10000, "Java", "c#", "c++");
				tech1.show();
				tech1.register();
				Console.WriteLine();
				SoftSkillsInstractor soft1 = new SoftSkillsInstractor(2, "Fatma Assem", 22, 10000, 10);
				soft1.show();
				soft1.register();

			}
			catch(Exception e)
			{
				Console.WriteLine("There is aproblem please try later");
				excepout = $"Exception type: {e.GetType().Name}\nMessage: {e.Message}\nData: {e.Data.ToString()}\n\n";
				if (e.InnerException != null)
				{
					excepout += e.InnerException.ToString();
				}
			}
			finally
			{
				File.AppendAllText(filePath, excepout);
			}
			Console.ReadKey();
		}
	}
}
