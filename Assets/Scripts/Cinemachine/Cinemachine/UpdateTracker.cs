using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.Undoc)]
	internal class UpdateTracker
	{
		public enum UpdateClock
		{
			Fixed = 0,
			Late = 1
		}

		private class UpdateStatus
		{
			private const int kWindowSize = 30;

			private int windowStart;

			private int numWindowLateUpdateMoves;

			private int numWindowFixedUpdateMoves;

			private int numWindows;

			private int lastFrameUpdated;

			private Matrix4x4 lastPos;

			public UpdateClock PreferredUpdate { get; private set; }

			public UpdateStatus(int currentFrame, Matrix4x4 pos)
			{
			}

			public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos)
			{
			}
		}

		private static Dictionary<Transform, UpdateStatus> mUpdateStatus;

		private static List<Transform> sToDelete;

		private static float mLastUpdateTime;

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}

		private static void UpdateTargets(UpdateClock currentClock)
		{
		}

		public static UpdateClock GetPreferredUpdate(Transform target)
		{
			return default(UpdateClock);
		}

		public static void OnUpdate(UpdateClock currentClock)
		{
		}
	}
}
