using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaRT.Helpers;
namespace DaRT.Classes
{
	public class GlobalBan: IEquatable<GlobalBan>
	{
		public string uid { get; set; }
		public string guid { get; set; }
		public GlobalBan(string uid, string guid)
		{
			this.uid = uid;
			this.guid = guid;
		}
		public GlobalBan(string somethinng)
		{
			if (somethinng.Length == 32)
			{
				this.guid = somethinng;
				this.uid = WebClientAsd.GetUID(guid);
			}
			else
			{
				uid = somethinng;
				guid = String.Empty;
			}
		}
		public static bool operator ==(GlobalBan a, GlobalBan b)
		{
			if ((a.guid == b.guid) && (a.uid == b.uid))
				return true;
			return false;
		}
		public static bool operator !=(GlobalBan a, GlobalBan b)
		{
			if ((a.guid == b.guid) && (a.uid == b.uid))
				return false;
			return true;
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType())
				return false;
			return (GlobalBan)obj == this;
		}
		public bool Equals(GlobalBan other)
		{
			return other == this;
		}
	}
}
