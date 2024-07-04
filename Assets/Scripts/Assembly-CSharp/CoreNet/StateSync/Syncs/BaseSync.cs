using CoreNet.StateSync.Routers;
using CoreNet.StateSync.States;
using UnityEngine;

namespace CoreNet.StateSync.Syncs
{
	public abstract class BaseSync : MonoBehaviour
	{
		public const int BUFFER_SIZE = 30;

		public bool Lazy;

		public float _SyncClockTime;

		public bool _UpdateOnFixed;

		public float FPS;

		public BaseSyncRouter _routerFootprint;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void FixedUpdateImpl()
		{
		}

		public void UpdateImpl()
		{
		}

		private bool FPSLow()
		{
			return false;
		}

		public void TryUpdate()
		{
		}

		private void UpdateRemoteClient()
		{
		}

		public virtual void SetSyncing(bool syncing, bool isServer)
		{
		}

		public abstract void AddState(BaseState state);

		public abstract BaseState GetRefState();

		public abstract void Init();

		protected abstract void UpdatePosition();
	}
}
