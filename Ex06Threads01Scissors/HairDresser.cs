using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex06Threads01Scissors
{
	class HairDresser
	{
		public int ID{get;private set;}

		public bool hasCustomer;

		List<Scissor> sharedScissors;
		public HairDresser(Scissor s1, Scissor s2, int id)
		{
			ID = id;
			sharedScissors = new List<Scissor>();
			hasCustomer = true;
			sharedScissors.Add(s1);
			sharedScissors.Add(s2);
		}
		public List<Scissor> getScissors()
		{
			return sharedScissors;
		}

		public void Work()
		{
			if (hasCustomer)
			{
				lock (sharedScissors[0])
				{
					lock (sharedScissors[1])
					{
						for(int i = 0; i< 10; i++)
						{
							Thread.Sleep(Program.rand.Next(100, 600));
						}
						hasCustomer = false;
						Console.WriteLine("HairDresser " + ID + " done!");
					}
				}
			}
		}
	}
}
