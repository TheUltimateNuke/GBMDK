using System.Collections.Generic;

namespace CoreNet.Messaging.Permissions
{
	public abstract class Permission
	{
		protected List<int> _List;

		public abstract bool IsPermitted(int connectionId);

		public void Add(int connectionId)
		{
		}

		public void Remove(int connectionId)
		{
		}
	}
}
