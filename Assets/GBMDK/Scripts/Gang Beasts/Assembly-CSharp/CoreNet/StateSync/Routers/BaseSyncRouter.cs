using System.Runtime.InteropServices;
using CoreNet.StateSync.Routers.Mappings;
using CoreNet.StateSync.Syncs;
using CoreNet.StateSync.Triggers;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.StateSync.Routers
{
	[NetworkSettings(channel = 1, sendInterval = 0f)]
	public abstract class BaseSyncRouter : NetworkBehaviour
	{
		public bool Lazy;

		public GameObject TargetChild;

		[Range(0f, 1f)]
		public float DeltaThreshold;

		private float time;

		private BaseSync _sync;

		private bool syncValid;

		protected BaseSyncTrigger[] _Triggers;

		private float _LastCheck;

		private bool _Lock;

		[SyncVar(hook = "SetSyncing")]
		private bool _Syncing;

		[SerializeField]
		private bool _SyncImmediately;

		private bool _StartSync;

		protected BaseSync _Sync
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BaseSync SyncTarget => null;

		public bool Syncing => false;

		public bool Network_Syncing
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateImpl()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void LoadLazySync()
		{
		}

		protected virtual void InitSync()
		{
		}

		private void LoadSync()
		{
		}

		public override void OnStartClient()
		{
		}

		public override void OnStartServer()
		{
		}

		[ServerCallback]
		protected virtual void OnStartSync()
		{
		}

		[ServerCallback]
		protected virtual void OnStopSync()
		{
		}

		protected abstract void InitMappings();

		protected abstract BaseSync GetSync();

		[Client]
		protected abstract void UpdateState();

		[Server]
		protected abstract void CalculateMappings();

		[Server]
		protected void TryCalculateMappings()
		{
		}

		[Server]
		protected short CalculateMapping(short syncVar, float current, ref float prev, SyncMapping mapping)
		{
			return 0;
		}

		protected BaseSync GetSyncOfType<T>() where T : BaseSync
		{
			return null;
		}

		private BaseSync GetLazySync<T>() where T : BaseSync
		{
			return null;
		}

		private BaseSync GetPredefinedSync<T>() where T : BaseSync
		{
			return null;
		}

		protected virtual void PostSyncSet(bool syncing)
		{
		}

		private void SetSyncing(bool syncing)
		{
		}

		private void Sync()
		{
		}

		private void SetupServerSync()
		{
		}

		protected virtual void LoadSyncTrigger()
		{
		}

		private bool TimeToCheck()
		{
			return false;
		}

		protected bool DeltaOverThreshold(float current, float prev)
		{
			return false;
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
