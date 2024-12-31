using System.Collections.Generic;
using UnityEngine;

namespace GB.Core.Test
{
	public class SegmentSuppressorManager : MonoBehaviour
	{
		private const int k_SegmentSuppressorPreAllocation = 150;

		private List<SegmentSuppressor> m_SegmentSuppressors;

		public static SegmentSuppressorManager Instance { get; private set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void AddSegmentSuppressor(SegmentSuppressor segmentSuppressor)
		{
		}

		public void RemoveSegmentSuppressor(SegmentSuppressor segmentSuppressor)
		{
		}
	}
}
