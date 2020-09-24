using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_227_Milestone_Project
{
    public class PlayerStats
    {
			public string name { get; set; }

			public string difficulty { get; set; }

			public TimeSpan time { get; set; }

		//constructor
		public PlayerStats(string name, string difficulty, TimeSpan time)
        {
			this.name = name;
			this.difficulty = difficulty;
			this.time = time;
        }

		public int CompareTo(PlayerStats other)
        {
			return time.CompareTo(other.time);
        }
	}
}
