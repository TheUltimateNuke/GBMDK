using SuperGenius.Lib.Burst.Easing;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Random
{
	[BurstCompile]
	public struct RandomPointsMinMaxRadiusWithScaleIJob : IJob
	{
		[Unity.Collections.ReadOnly]
		public uint RandomSeed;

		[Unity.Collections.ReadOnly]
		public Bounds Bounds;

		[Unity.Collections.ReadOnly]
		public float3 Scale;

		[Unity.Collections.ReadOnly]
		public float MinRadius;

		[Unity.Collections.ReadOnly]
		public float MaxRadius;

		[Unity.Collections.ReadOnly]
		public int MaxPoints;

		[Unity.Collections.ReadOnly]
		public EaseFuctions.EaseType EaseType;

		[Unity.Collections.ReadOnly]
		public bool SkipSafetyCheck;

		public NativeList<float3> RandomPositions;

		public void Execute()
		{
		}
	}
}
