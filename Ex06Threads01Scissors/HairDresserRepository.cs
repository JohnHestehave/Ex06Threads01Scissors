using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex06Threads01Scissors
{
	class HairDresserRepository
	{
		List<HairDresser> hairDressers;
		public HairDresserRepository()
		{
			hairDressers = new List<HairDresser>();
		}

		public HairDresser createHairDresser(Scissor s1, Scissor s2)
		{
			HairDresser hd = new HairDresser(s1, s2, hairDressers.Count()+1);
			hairDressers.Add(hd);
			return hd;
		}
		public List<HairDresser> getHairDressers()
		{
			return hairDressers;
		}

		public void StartWork()
		{
			foreach (HairDresser h in getHairDressers())
			{
				Thread thread = new Thread(new ThreadStart(h.Work));
				thread.Start();
			}
		}
	}
}
