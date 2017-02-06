using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Threads01Scissors
{
	class Scissor
	{
		
		public int ID { get; private set; }
		public Scissor(int id)
		{
			ID = id;
		}
	}
}
