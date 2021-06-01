using System;

namespace OnClick_Event { 
	
	public delegate void mydelgate(button btn);
	public class button
	{ 
		public string txt { get; set; }
		public int id { get; set; }

		public button(string txt, int id)
		{
			this.txt = txt;
			this.id = id;
		}
		public event mydelgate click;

		public void Onclick()
		{
			click(this);
		}
	}
	class page
	{
		public void show(button b)
		{
			Console.WriteLine(b.txt);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			button btn = new button("Save",1);
			page p = new page();
			btn.click += p.show;
			btn.Onclick();
			Console.ReadKey();

		}
	}
}
