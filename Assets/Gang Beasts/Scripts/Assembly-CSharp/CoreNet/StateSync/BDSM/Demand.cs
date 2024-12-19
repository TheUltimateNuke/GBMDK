using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	public class Demand
	{
		public Vector3 Position;

		public Quaternion Rotation;

		public float Weight;

		public Vector3 WeightAdjustedPosition => default(Vector3);

		public Demand(Vector3 position, Quaternion rotation, float weight)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
