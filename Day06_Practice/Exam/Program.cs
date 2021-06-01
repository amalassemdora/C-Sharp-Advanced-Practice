using System;

namespace Exam
{
	public delegate void mydel(Exam e,ExamArgs ea);
	public class ExamArgs
		{
		public String location { get; set; }
		public DateTime date { get; set; }

		public ExamArgs(String location, DateTime date)
		{
			this.location = location;
			this.date = date;
		}
	}

	public class Exam
	{
		public int id { get; set; }
		public string subject { get; set; }
		public int time { get; set; }
		public static event mydel StartExam;
		public Exam(int id = 0, string subject = " ", int time = 60)
		{
			this.id = id;
			this.subject = subject;
			this.time = time;

		}
		public void OnStartExam()
		{
			if (StartExam != null)
			{
				StartExam(this,new ExamArgs("Lab 3",DateTime.Now.AddHours(1)));
			}
		}
		public override string ToString()
		{
			return base.ToString();
		}
		public void PrintExam()
		{
			Console.WriteLine($"subject :{subject}\t\t\tTime :{time}");
		}
	}

	public class Student
	{
		public int id { get; set; }
		public string name{ get; set; }
		public int age { get; set; }
		public Student(int id, string name, int age)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			Exam.StartExam += TakeExam;
		}
		
	

		public void TakeExam(Exam ex, ExamArgs ea)
		{
			Console.WriteLine($"{this.name} take exam , @{ea.date} in {ea.location}.");
			ex.PrintExam();
		}
	}

	public class Staff
	{
		public int id { get; set; }
		public string name { get; set; }
		public Staff(int id, string name)
		{
			this.id = id;
			this.name = name;
			Exam.StartExam += Moniter;
		
	    }
		public void Moniter(Exam ex, ExamArgs ea)
		{
			Console.WriteLine($"{this.name} start moniter on {ex.subject} exam, Time :{ex.time} hours , @ {ea.date} in {ea.location}");

		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Exam ex = new Exam(1,"Math",2);
			Student s1 = new Student(1, "Amal Assem", 25);
			Student s2 = new Student(2, "Fatma Assem", 22);

			Staff st1 = new Staff(1, "Ahmed Ali");
			ex.OnStartExam();
			Console.ReadKey();
		}
	}
}
