using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06Threads01Scissors
{
	class ScissorRepository
	{
		List<Scissor> scissors;

		public ScissorRepository()
		{
			scissors = new List<Scissor>();
		}
		public Scissor createScissor()
		{
			Scissor s = new Scissor(scissors.Count()+1);
			scissors.Add(s);
			return s;
		}
		
	}
}
