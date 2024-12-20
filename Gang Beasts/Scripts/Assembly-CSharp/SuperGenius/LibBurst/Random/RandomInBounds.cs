using SuperGenius.Lib.Burst.Geometry;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.LibBurst.Random
{
	public struct RandomInBounds : IJob
	{
		public uint RandomSeed;

		public Bounds Bounds;

		public NativeArray<float3> RandomPositions;

		public void Execute()
		{
		}
	}
}
