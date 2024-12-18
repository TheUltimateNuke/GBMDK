using System.Collections.Generic;

namespace UnityEngine.Networking
{
	internal class NetworkMessageHandlers
	{
		private Dictionary<short, NetworkMessageDelegate> m_MsgHandlers;

		internal void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void RegisterHandler(short msgType, NetworkMessageDelegate handler)
		{
		}

		public void UnregisterHandler(short msgType)
		{
		}

		internal NetworkMessageDelegate GetHandler(short msgType)
		{
			return null;
		}

		internal Dictionary<short, NetworkMessageDelegate> GetHandlers()
		{
			return null;
		}

		internal void ClearMessageHandlers()
		{
		}
	}
}
