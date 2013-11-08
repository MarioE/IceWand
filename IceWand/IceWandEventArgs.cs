using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;

namespace IceWand
{
	public class IceWandEventArgs : EventArgs
	{
		public int Data
		{
			get;
			private set;
		}
		public TSPlayer Player
		{
			get;
			private set;
		}
		public int X
		{
			get;
			private set;
		}
		public int Y
		{
			get;
			private set;
		}

		public IceWandEventArgs(int x, int y, TSPlayer player, int data = 0)
		{
			Data = data;
			Player = player;
			X = x;
			Y = y;
		}
	}
}
