using System;

namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkTransformChild")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkTransformChild : NetworkBehaviour
	{
		[SerializeField]
		private Transform m_Target;

		[SerializeField]
		private uint m_ChildIndex;

		private NetworkTransform m_Root;

		[SerializeField]
		private float m_SendInterval;

		[SerializeField]
		private NetworkTransform.AxisSyncMode m_SyncRotationAxis;

		[SerializeField]
		private NetworkTransform.CompressionSyncMode m_RotationSyncCompression;

		[SerializeField]
		private float m_MovementThreshold;

		[SerializeField]
		private float m_InterpolateRotation;

		[SerializeField]
		private float m_InterpolateMovement;

		[SerializeField]
		private NetworkTransform.ClientMoveCallback3D m_ClientMoveCallback3D;

		private Vector3 m_TargetSyncPosition;

		private Quaternion m_TargetSyncRotation3D;

		private float m_LastClientSyncTime;

		private float m_LastClientSendTime;

		private Vector3 m_PrevPosition;

		private Quaternion m_PrevRotation;

		private const float k_LocalMovementThreshold = 1E-05f;

		private const float k_LocalRotationThreshold = 1E-05f;

		private NetworkWriter m_LocalTransformWriter;

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint childIndex => 0u;

		public float sendInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public NetworkTransform.AxisSyncMode syncRotationAxis
		{
			get
			{
				return default(NetworkTransform.AxisSyncMode);
			}
			set
			{
			}
		}

		public NetworkTransform.CompressionSyncMode rotationSyncCompression
		{
			get
			{
				return default(NetworkTransform.CompressionSyncMode);
			}
			set
			{
			}
		}

		public float movementThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float interpolateRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float interpolateMovement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public NetworkTransform.ClientMoveCallback3D clientMoveCallback3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float lastSyncTime => 0f;

		public Vector3 targetSyncPosition => default(Vector3);

		public Quaternion targetSyncRotation3D => default(Quaternion);

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			return false;
		}

		private void SerializeModeTransform(NetworkWriter writer)
		{
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		private void UnserializeModeTransform(NetworkReader reader, bool initialState)
		{
		}

		private void FixedUpdate()
		{
		}

		private void FixedUpdateServer()
		{
		}

		private void FixedUpdateClient()
		{
		}

		private void Update()
		{
		}

		private bool HasMoved()
		{
			return false;
		}

		[Client]
		private void SendTransform()
		{
		}

		internal static void HandleChildTransform(NetworkMessage netMsg)
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
	}
}
