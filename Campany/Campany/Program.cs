using System;

namespace Campany
{
	enum gender
	{
		Male,
		Female
	}
	[Flags]
	enum security
	{
		guest = 1,
		Developer = 2,
		secretary = 4,
		DBA = 8
	}
	class HiringDate//: IComparable
	{
		#region prop
		public int day { get; set; }
		public int month { get; set; }
		public int year { get; set; }
		#endregion
		public HiringDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}
		public override string ToString()
		{
			return $"{day}/{month}/{year}";
		}
		
		/*public int CompareTo(object obj)
		{
			HiringDate h = obj as HiringDate;
			if (year.CompareTo(h.year) == 0)
			{
				if (month.CompareTo(h.month) == 0)
				{
					if (day.CompareTo(h.day) == 0)
						return day.CompareTo(h.day);
				}
				else
				{
					return month.CompareTo(h.month);
				}
			}
			else
			{
				return year.CompareTo(h.year);
			}
			throw new NotImplementedException();
		}*/
	}
	class Employee : IComparable
	{
		//ID, security level, salary, hire date and Gender.
		#region prop

		public int Id { get; set; }
		public security Security_level { get; set; }
		public decimal Salary { get; set; }
		public HiringDate Hire_date { get; set; }
		public gender Gen { get; set; }
		#endregion
		#region ctor
		public Employee(int id, security security_level, decimal salary, HiringDate hire_date, gender gen)
		{
			this.Id = id;
			this.Security_level = security_level;
			this.Salary = salary;
			this.Hire_date = hire_date;
			this.Gen = gen;
		}
		#endregion

		#region methods
		public override string ToString()
		{
			return $"ID: {Id}\nSecurity level: {Security_level}\nSalary: { Salary}\nHire Date: {Hire_date}\nGender: {Gen}";
		}
		
		public int CompareTo(object obj)
		{
			Employee emp = obj as Employee;
			if (Hire_date.year.CompareTo(emp.Hire_date.year) == 0)
			{
				if (Hire_date.month.CompareTo(emp.Hire_date.month) == 0)
				{
						return Hire_date.day.CompareTo(emp.Hire_date.day);
				}
				else
				{
					return Hire_date.month.CompareTo(emp.Hire_date.month);
				}
			}
			else
			{
				return Hire_date.year.CompareTo(emp.Hire_date.year);
			}
		}
		#endregion

	}
	class Program
	{
		static void Main(string[] args)
		{
			security security_officer = security.DBA | security.Developer | security.guest | security.secretary;
			Employee[] emparr = new Employee[3];
			emparr[0] = new Employee(1, security.guest, 10000, new HiringDate(2, 10, 2020), gender.Female);
			emparr[1] = new Employee(2, security.DBA, 15000, new HiringDate(2, 2, 2019), gender.Male);
			emparr[2] = new Employee(3, security_officer, 16000, new HiringDate(2, 2, 2020), gender.Female);
			Array.Sort(emparr);
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"*************Employee #{i+1}*************");
				Console.WriteLine(emparr[i]);
			}
			Console.ReadKey();
		}
	}
}
