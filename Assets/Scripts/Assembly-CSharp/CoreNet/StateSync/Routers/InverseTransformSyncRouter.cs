using CoreNet.StateSync.Syncs;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.StateSync.Routers
{
	public class InverseTransformSyncRouter : TransformSyncRouter
	{
		private string RelativeTransformName;

		public Transform _RelativeTransform;

		protected override BaseSync GetSync()
		{
			return null;
		}

		protected override void CalculatePositionMappings(Vector3 position)
		{
		}

		protected override Vector3 GetRecontructedPosition()
		{
			return default(Vector3);
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
