using System.Collections.Generic;
using CoreNet.StateSync.Routers;
using CoreNet.StateSync.Syncs;
using UnityEngine;

namespace CoreNet.StateSync
{
	public class LazySyncModel : MonoBehaviour
	{
		private bool _ModelLoaded;

		private List<BaseSyncRouter> _Routers;

		private List<BaseSync> _Syncs;

		public T GetNext<T>() where T : BaseSync
		{
			return null;
		}

		public void Load()
		{
		}

		private void PrintDebugInfo()
		{
		}
	}
}
