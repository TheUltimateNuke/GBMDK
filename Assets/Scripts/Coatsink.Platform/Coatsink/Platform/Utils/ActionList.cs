using System;

namespace Coatsink.Platform.Utils
{
	public class ActionList
	{
		private object _actionLock;

		private Action _waitingActions;

		private string _listName;

		public ActionList(string name)
		{
		}

		public void Update()
		{
		}
	}
}
