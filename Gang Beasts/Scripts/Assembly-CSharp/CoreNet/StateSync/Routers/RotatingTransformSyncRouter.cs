using System.Runtime.InteropServices;
using CoreNet.StateSync.Routers.Mappings;
using CoreNet.StateSync.Syncs;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.StateSync.Routers
{
	[NetworkSettings(channel = 1, sendInterval = 0f)]
	public class RotatingTransformSyncRouter : BaseSyncRouter
	{
		[SyncVar]
		private short _PositionX;

		[SyncVar]
		private short _PositionY;

		[SyncVar]
		private short _PositionZ;

		[SyncVar]
		private short _RotationX;

		[SyncVar]
		private short _RotationY;

		[SyncVar]
		private short _RotationZ;

		[SyncVar]
		private short _RotationW;

		[SyncVar]
		private short _ScaleX;

		[SyncVar]
		private short _ScaleY;

		[SyncVar]
		private short _ScaleZ;

		public static float DefaultSyncRange;

		public bool CustomSyncRange;

		[Tooltip("Larger ranges will be of lower networked fidelity")]
		public float SyncRange;

		protected Vector3 _PrevPosition;

		protected Quaternion _PrevQuaternion;

		protected Vector3 _PrevScale;

		protected SyncMapping _PositionMapping;

		protected SyncMapping _RotationMapping;

		protected SyncMapping _ScaleMapping;

		protected TransformSync _syncCache;

		protected Vector3 scaleStorage;

		protected Vector3 reconPosStorage;

		protected Vector3 reconScaleStorage;

		public short PositionX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short PositionY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short PositionZ
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short RotationX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short RotationY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short RotationZ
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short RotationW
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short ScaleX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short ScaleY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short ScaleZ
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public short Network_PositionX
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

		public short Network_PositionY
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

		public short Network_PositionZ
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

		public short Network_RotationX
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

		public short Network_RotationY
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

		public short Network_RotationZ
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

		public short Network_RotationW
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

		public short Network_ScaleX
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

		public short Network_ScaleY
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

		public short Network_ScaleZ
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

		protected override void InitMappings()
		{
		}

		protected override void InitSync()
		{
		}

		protected override void PostSyncSet(bool syncing)
		{
		}

		private void CacheCurrentTransform()
		{
		}

		protected override BaseSync GetSync()
		{
			return null;
		}

		[Server]
		public void ForceSync()
		{
		}

		[Server]
		protected override void CalculateMappings()
		{
		}

		[Client]
		protected override void UpdateState()
		{
		}

		protected virtual void CalculatePositionMappings(Vector3 position)
		{
		}

		protected virtual void CalculateRotationMappings(Quaternion rotation)
		{
		}

		protected void CalculateScaleMappings(Vector3 scale)
		{
		}

		protected virtual Vector3 GetRecontructedPosition()
		{
			return default(Vector3);
		}

		protected virtual Vector3 GetReconstructedScale()
		{
			return default(Vector3);
		}

		protected virtual Quaternion GetRecontructedRotation()
		{
			return default(Quaternion);
		}

		private void UNetVersion()
		{
		}

		public override int GetNetworkChannel()
		{
			return 0;
		}

		public override float GetNetworkSendInterval()
		{
			return 0f;
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
