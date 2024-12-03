using UnityEngine;

namespace Cinemachine.Utility
{
	public class HeadingTracker
	{
		private struct Item
		{
			public Vector3 velocity;

			public float weight;

			public float time;
		}

		private Item[] mHistory;

		private int mTop;

		private int mBottom;

		private int mCount;

		private Vector3 mHeadingSum;

		private float mWeightSum;

		private float mWeightTime;

		private Vector3 mLastGoodHeading;

		private static float mDecayExponent;

		public int FilterSize => 0;

		public HeadingTracker(int filterSize)
		{
		}

		private void ClearHistory()
		{
		}

		private static float Decay(float time)
		{
			return 0f;
		}

		public void Add(Vector3 velocity)
		{
		}

		private void PopBottom()
		{
		}

		public void DecayHistory()
		{
		}

		public Vector3 GetReliableHeading()
		{
			return default(Vector3);
		}
	}
}
