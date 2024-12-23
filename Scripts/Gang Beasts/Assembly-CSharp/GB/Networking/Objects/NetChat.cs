using System.Collections.Generic;
using CoreNet.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetChat : NetConnectionAssociation
	{
		private List<bool> _communication;

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public void SetVoice(int controller, bool active)
		{
		}

		public bool GetVoice(int controller)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
