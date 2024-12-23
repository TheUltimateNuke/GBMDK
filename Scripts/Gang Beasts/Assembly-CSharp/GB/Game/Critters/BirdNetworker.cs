using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Game.Critters
{
	public class BirdNetworker : NetworkBehaviour
	{
		[SerializeField]
		private BirdActor targetBird;

		[SyncVar(hook = "UpdateState")]
		private int birdActorState;

		public int BirdActorState
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NetworkbirdActorState
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

		private void Start()
		{
		}

		public void UpdateState(int newState)
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
