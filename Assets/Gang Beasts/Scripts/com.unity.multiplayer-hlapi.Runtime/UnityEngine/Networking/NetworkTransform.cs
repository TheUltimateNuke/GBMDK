using System;

namespace UnityEngine.Networking
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkTransform")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkTransform : NetworkBehaviour
	{
		public enum TransformSyncMode
		{
			SyncNone = 0,
			SyncTransform = 1,
			SyncRigidbody2D = 2,
			SyncRigidbody3D = 3,
			SyncCharacterController = 4
		}

		public enum AxisSyncMode
		{
			None = 0,
			AxisX = 1,
			AxisY = 2,
			AxisZ = 3,
			AxisXY = 4,
			AxisXZ = 5,
			AxisYZ = 6,
			AxisXYZ = 7
		}

		public enum CompressionSyncMode
		{
			None = 0,
			Low = 1,
			High = 2
		}

		public delegate bool ClientMoveCallback3D(ref Vector3 position, ref Vector3 velocity, ref Quaternion rotation);

		public delegate bool ClientMoveCallback2D(ref Vector2 position, ref Vector2 velocity, ref float rotation);

		[SerializeField]
		private TransformSyncMode m_TransformSyncMode;

		[SerializeField]
		private float m_SendInterval;

		[SerializeField]
		private AxisSyncMode m_SyncRotationAxis;

		[SerializeField]
		private CompressionSyncMode m_RotationSyncCompression;

		[SerializeField]
		private bool m_SyncSpin;

		[SerializeField]
		private float m_MovementTheshold;

		[SerializeField]
		private float m_VelocityThreshold;

		[SerializeField]
		private float m_SnapThreshold;

		[SerializeField]
		private float m_InterpolateRotation;

		[SerializeField]
		private float m_InterpolateMovement;

		[SerializeField]
		private ClientMoveCallback3D m_ClientMoveCallback3D;

		[SerializeField]
		private ClientMoveCallback2D m_ClientMoveCallback2D;

		private Rigidbody m_RigidBody3D;

		private Rigidbody2D m_RigidBody2D;

		private CharacterController m_CharacterController;

		private bool m_Grounded;

		private Vector3 m_TargetSyncPosition;

		private Vector3 m_TargetSyncVelocity;

		private Vector3 m_FixedPosDiff;

		private Quaternion m_TargetSyncRotation3D;

		private Vector3 m_TargetSyncAngularVelocity3D;

		private float m_TargetSyncRotation2D;

		private float m_TargetSyncAngularVelocity2D;

		private float m_LastClientSyncTime;

		private float m_LastClientSendTime;

		private Vector3 m_PrevPosition;

		private Quaternion m_PrevRotation;

		private float m_PrevRotation2D;

		private float m_PrevVelocity;

		private const float k_LocalMovementThreshold = 1E-05f;

		private const float k_LocalRotationThreshold = 1E-05f;

		private const float k_LocalVelocityThreshold = 1E-05f;

		private const float k_MoveAheadRatio = 0.1f;

		private NetworkWriter m_LocalTransformWriter;

		public TransformSyncMode transformSyncMode
		{
			get
			{
				return default(TransformSyncMode);
			}
			set
			{
			}
		}

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

		public AxisSyncMode syncRotationAxis
		{
			get
			{
				return default(AxisSyncMode);
			}
			set
			{
			}
		}

		public CompressionSyncMode rotationSyncCompression
		{
			get
			{
				return default(CompressionSyncMode);
			}
			set
			{
			}
		}

		public bool syncSpin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float movementTheshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float velocityThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float snapThreshold
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

		public ClientMoveCallback3D clientMoveCallback3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ClientMoveCallback2D clientMoveCallback2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterController characterContoller => null;

		public Rigidbody rigidbody3D => null;

		public Rigidbody2D rigidbody2D => null;

		public float lastSyncTime => 0f;

		public Vector3 targetSyncPosition => default(Vector3);

		public Vector3 targetSyncVelocity => default(Vector3);

		public Quaternion targetSyncRotation3D => default(Quaternion);

		public float targetSyncRotation2D => 0f;

		public bool grounded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			return false;
		}

		private void SerializeModeTransform(NetworkWriter writer)
		{
		}

		private void VerifySerializeComponentExists()
		{
		}

		private void SerializeMode3D(NetworkWriter writer)
		{
		}

		private void SerializeModeCharacterController(NetworkWriter writer)
		{
		}

		private void SerializeMode2D(NetworkWriter writer)
		{
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		private void UnserializeModeTransform(NetworkReader reader, bool initialState)
		{
		}

		private void UnserializeMode3D(NetworkReader reader, bool initialState)
		{
		}

		private void UnserializeMode2D(NetworkReader reader, bool initialState)
		{
		}

		private void UnserializeModeCharacterController(NetworkReader reader, bool initialState)
		{
		}

		private void FixedUpdate()
		{
		}

		private void FixedUpdateServer()
		{
		}

		private bool CheckVelocityChanged()
		{
			return false;
		}

		private void FixedUpdateClient()
		{
		}

		private void InterpolateTransformMode3D()
		{
		}

		private void InterpolateTransformModeCharacterController()
		{
		}

		private void InterpolateTransformMode2D()
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

		public static void HandleTransform(NetworkMessage netMsg)
		{
		}

		private static void WriteAngle(NetworkWriter writer, float angle, CompressionSyncMode compression)
		{
		}

		private static float ReadAngle(NetworkReader reader, CompressionSyncMode compression)
		{
			return 0f;
		}

		public static void SerializeVelocity3D(NetworkWriter writer, Vector3 velocity, CompressionSyncMode compression)
		{
		}

		public static void SerializeVelocity2D(NetworkWriter writer, Vector2 velocity, CompressionSyncMode compression)
		{
		}

		public static void SerializeRotation3D(NetworkWriter writer, Quaternion rot, AxisSyncMode mode, CompressionSyncMode compression)
		{
		}

		public static void SerializeRotation2D(NetworkWriter writer, float rot, CompressionSyncMode compression)
		{
		}

		public static void SerializeSpin3D(NetworkWriter writer, Vector3 angularVelocity, AxisSyncMode mode, CompressionSyncMode compression)
		{
		}

		public static void SerializeSpin2D(NetworkWriter writer, float angularVelocity, CompressionSyncMode compression)
		{
		}

		public static Vector3 UnserializeVelocity3D(NetworkReader reader, CompressionSyncMode compression)
		{
			return default(Vector3);
		}

		public static Vector3 UnserializeVelocity2D(NetworkReader reader, CompressionSyncMode compression)
		{
			return default(Vector3);
		}

		public static Quaternion UnserializeRotation3D(NetworkReader reader, AxisSyncMode mode, CompressionSyncMode compression)
		{
			return default(Quaternion);
		}

		public static float UnserializeRotation2D(NetworkReader reader, CompressionSyncMode compression)
		{
			return 0f;
		}

		public static Vector3 UnserializeSpin3D(NetworkReader reader, AxisSyncMode mode, CompressionSyncMode compression)
		{
			return default(Vector3);
		}

		public static float UnserializeSpin2D(NetworkReader reader, CompressionSyncMode compression)
		{
			return 0f;
		}

		public override int GetNetworkChannel()
		{
			return 0;
		}

		public override float GetNetworkSendInterval()
		{
			return 0f;
		}

		public override void OnStartAuthority()
		{
		}
	}
}
