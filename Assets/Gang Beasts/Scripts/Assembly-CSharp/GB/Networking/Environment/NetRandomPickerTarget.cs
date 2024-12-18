using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Environment
{
	public class NetRandomPickerTarget : MonoBehaviour
	{
		[SerializeField]
		private List<NetworkIdentity> ChildrenToDestroy;

		public void TriggerDestroy()
		{
		}

		public void TriggerSubDestroy()
		{
		}
	}
}
