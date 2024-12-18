using System.Collections.Generic;
using UnityEngine;

namespace GB.Stages
{
	public class PierManager : MonoBehaviour
	{
		[SerializeField]
		private List<PlankChunk> PlankChunkRefs;

		[SerializeField]
		private int MinimumChunkAllowance;

		[SerializeField]
		private int MaximumChunkAllowance;

		private int cachedChunkAllowance;

		private int chunksFallen;

		private void Start()
		{
		}

		public void AlertChunkFell(PlankChunk fallingChunk)
		{
		}
	}
}
