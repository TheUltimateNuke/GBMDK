using System.Collections.Generic;
using CoreNet.StateSync.Routers;
using UnityEngine;

namespace CoreNet.StateSync.Syncs
{
	public class SyncManager : MonoBehaviour
	{
		private List<BaseSync> m_BaseSyncsOnUpdate;

		private List<BaseSync> m_BaseSyncsOnFixedUpdate;

		private List<BaseSyncRouter> m_BaseSyncRouters;

		private static SyncManager m_Instance;

		public static SyncManager Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Awake()
		{
		}

		public void AddBaseSync(BaseSync baseSync)
		{
		}

		public void RemoveBaseSync(BaseSync baseSync)
		{
		}

		public void AddBaseSyncRouter(BaseSyncRouter baseSyncRouter)
		{
		}

		public void RemoveBaseSyncRouter(BaseSyncRouter baseSyncRouter)
		{
		}
	}
}
