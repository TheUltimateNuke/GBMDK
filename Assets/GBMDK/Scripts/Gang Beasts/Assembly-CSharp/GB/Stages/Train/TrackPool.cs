using System.Collections.Generic;
using CoreNet.Pooling;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Train
{
	public class TrackPool : NetworkBehaviour
	{
		private struct SpawnQueue
		{
			public Direction direction;

			public int props;

			public byte tag;

			public SpawnQueue(Direction dir, int props, byte tag)
			{
				direction = default(Direction);
				this.props = 0;
				this.tag = 0;
			}
		}

		public enum Type
		{
			cliffside = 0
		}

		public enum Direction
		{
			Straight = 0,
			Left = 1,
			Right = 2,
			EscalationStart = 3,
			EscalationEnd = 4
		}

		public enum Escalation
		{
			landSlide = 0
		}

		public int activeTrackPieces;

		public float trackMovementSpeed;

		public float maxWonderArea;

		public float forceReturnArea;

		[Space]
		[Header("Pools")]
		public Pool trackPoolStright;

		public Pool trackPoolLeft;

		public Pool trackPoolRight;

		public Pool trackEscalationStart;

		public Pool trackEscalationEnd;

		[Space]
		[Header("Landslide Escalation")]
		public float maxLandslideBoulderScale;

		public Transform[] landSlideBoulderSpawns;

		[SerializeField]
		public Pool[] boulderPool;

		[Header("Escalation Timing")]
		public Vector2 startEscalationRange;

		public Vector2 escalationDurationRange;

		private float startEscalation;

		private float endEscalation;

		[HideInInspector]
		public int trackQueue;

		private bool _gameStarted;

		private TrackMover _lastTrack;

		[Header("Debug")]
		public Direction nextTrack;

		private Vector3 offsetStraight;

		private Vector3 offsetLeft;

		private Vector3 offsetRight;

		private Escalation escalation;

		private float escalationTimer;

		private bool startEscalationTriggered;

		private bool endEscalationTriggered;

		private Vector3 trackEndPoint;

		private Queue<SpawnQueue> _clientSpawnQueue;

		[HideInInspector]
		public List<TrackMover> activeTrack;

		private byte _trackTag;

		private static int kRpcRpc_SpawnTrack;

		private static int kRpcRpc_SetProps;

		public TrackMover LastTrack => null;

		public Vector3 NextSpawnPoint => default(Vector3);

		public TrackMover GetTrack(byte syncTag)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void GameStarted()
		{
		}

		public void Update()
		{
		}

		[ContextMenu("Force Escalation Start")]
		private void StartEscalation()
		{
		}

		[ContextMenu("Force Escalation End")]
		private void EndEscalation()
		{
		}

		[ContextMenu("Force Rock Spawn")]
		private void SpawnRock()
		{
		}

		[Server]
		[ContextMenu("Force Track Spawn")]
		public void SpawnTrack()
		{
		}

		public bool SpawnTrack(Pool pool)
		{
			return false;
		}

		public void SpawnTrack(TrackMover track)
		{
		}

		private void _lastTrack_OnRepool(IPooledItem item)
		{
		}

		[Server]
		private void SpawnTrack(Direction nextDirection)
		{
		}

		[ClientRpc]
		private void Rpc_SpawnTrack(Direction nextDirection, int props, byte tag)
		{
		}

		private bool SpawnTrackLogic(Direction nextDirection)
		{
			return false;
		}

		[Server]
		private bool FallbackSpawn(ref Direction fallbackTo)
		{
			return false;
		}

		[ClientRpc]
		private void Rpc_SetProps(int tag, int props)
		{
		}

		private void UNetVersion()
		{
		}

		protected static void InvokeRpcRpc_SpawnTrack(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		protected static void InvokeRpcRpc_SetProps(NetworkBehaviour obj, NetworkReader reader)
		{
		}

		public void CallRpc_SpawnTrack(Direction nextDirection, int props, byte tag)
		{
		}

		public void CallRpc_SetProps(int tag, int props)
		{
		}

		static TrackPool()
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
