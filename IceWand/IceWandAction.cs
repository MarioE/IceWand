using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IceWand
{
	public class IceWandAction
	{
		public EventHandler<IceWandEventArgs> callback;
		public string name;

		public IceWandAction(EventHandler<IceWandEventArgs> callback, string name)
		{
			this.callback = callback;
			this.name = name;
		}
	}
}
