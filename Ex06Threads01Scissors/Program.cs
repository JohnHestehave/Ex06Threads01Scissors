using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Threads01Scissors
{
	class Program
	{
		static HairDresserRepository hdr = new HairDresserRepository();
		static ScissorRepository sr = new ScissorRepository();
		static bool running = true;
		public static Random rand = new Random();
		static void Main(string[] args)
		{

			Scissor s1 = sr.createScissor();
			Scissor s2 = sr.createScissor();
			Scissor s3 = sr.createScissor();
			Scissor s4 = sr.createScissor();
			Scissor s5 = sr.createScissor();
			Scissor s6 = sr.createScissor();
			hdr.createHairDresser(s1, s2);
			hdr.createHairDresser(s2, s3);
			hdr.createHairDresser(s3, s4);
			hdr.createHairDresser(s4, s5);
			hdr.createHairDresser(s5, s6);
			hdr.createHairDresser(s6, s1);

			while (running)
			{
				UpdateStatus();
				string cmd = Console.ReadLine();
				switch (cmd)
				{
					case "1":
						hdr.StartWork();
						break;
					case "2":
						running = false;
						break;
				}
				//running = false;
			}
		}
		static void UpdateStatus()
		{
			Console.Clear();
			foreach (HairDresser h in hdr.getHairDressers())
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("Hair dresser ID: " + h.ID + " - " + (h.hasCustomer ? "Currently working" : "On break"));
				foreach (Scissor s in h.getScissors())
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Shares Scissor ID: " + s.ID);
				}
			}
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
