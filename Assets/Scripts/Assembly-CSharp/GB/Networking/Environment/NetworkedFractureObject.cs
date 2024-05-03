using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Networking.Environment
{
	public class NetworkedFractureObject : MonoBehaviour
	{
		[Serializable]
		public struct FracturePieceInfo
		{
			public GameObject FracturePiece;

			[HideInInspector]
			public Vector3 WorldSpaceOffset;
		}

		[SerializeField]
		private float ForceThreshold;

		[SerializeField]
		public FracturePieceInfo[] FracturePieces;

		[SerializeField]
		public List<short> AssignedSyncIDs;

		private bool hasInitialised;

		private bool hasFractured;

		public void PrepareAllocation()
		{
		}

		public void AssignNetworkSyncID(int id)
		{
		}

		public void InitialiseFractureSync()
		{
		}

		private void Start()
		{
		}

		public void OnFracture(Vector3 CollisionPoint)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
