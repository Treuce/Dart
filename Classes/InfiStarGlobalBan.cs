using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaRT.Classes
{
	public class InfiStarGlobalBan
	{
		public string uid { get; set; }
		public string guid { get; set; }
		public InfiStarGlobalBan(string uid, string guid)
		{
			this.uid = uid;
			this.guid = guid;
		}
		public InfiStarGlobalBan(string somethinng)
		{
			if (somethinng.Length == 32)
			{
				this.guid = somethinng;
				this.uid = String.Empty;
			}
			else
			{
				uid = somethinng;
				guid = String.Empty;
			}
		}
	}
}
