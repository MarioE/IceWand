using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceWand
{
	public delegate void IceWandD(int X, int Y, int data, int plr);
	public class IWAction
	{
		public IceWandD action;
		public string name;

		public IWAction(IceWandD callback, string name)
		{
			action = callback;
			this.name = name;
		}
	}
}
