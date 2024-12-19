using System;

namespace Coatsink.Platform.Utils
{
	public class ActionQueue
	{
		private object _actionLock;

		private Action _waitingActions;

		private string _queueName;

		public ActionQueue(string name)
		{
		}

		public void Update()
		{
		}

		public void AddAction(Action action)
		{
		}
	}
}
