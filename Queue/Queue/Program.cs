using System;

namespace Queue
{
	class queue<t>
	{
		#region prop
		public t[] arr { get; set; }
		public int pin { get; set; }
		public int pout { get; set; }
		#endregion
		#region ctor
		public queue(int size)
		{
			arr = new t[size];
			pin = 0;
			pout = 0;
		}
		#endregion
		#region methods
		public void push(t item)
		{
			if (pin < arr.Length)
			{
				arr[pin] = item;
				pin++;
			}
		}

		public t pull()
		{
			if (pout < arr.Length)
			{

				return arr[pout++];

			}
			else
			{
				return default(t);
			}
			#endregion
		}
	}
		class Program
	{
		static void Main(string[] args)
		{
				queue<int> qin = new queue<int>(5);
				qin.push(1);
				qin.push(2);
				qin.push(3);
				qin.push(4);
				qin.push(5);

				Console.WriteLine(qin.pull());
				Console.WriteLine(qin.pull());
				Console.WriteLine(qin.pull());

			}
		}
}
