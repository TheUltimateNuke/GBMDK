using System.Runtime.InteropServices;
using UnityEngine.Networking;

namespace CoreNet
{
	public class CubeTest : NetworkBehaviour
	{
		[SyncVar]
		public int Counter;

		public int NetworkCounter
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		[ServerCallback]
		public void Update()
		{
		}

		private void UNetVersion()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
