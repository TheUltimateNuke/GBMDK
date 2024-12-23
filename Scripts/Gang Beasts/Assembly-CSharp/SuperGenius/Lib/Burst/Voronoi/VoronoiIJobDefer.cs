using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Voronoi
{
	[BurstCompile]
	public struct VoronoiIJobDefer : IJobParallelForDefer
	{
		[Unity.Collections.ReadOnly]
		public NativeList<float3> Locations;

		[Unity.Collections.ReadOnly]
		public Bounds Bounds;

		[NativeDisableParallelForRestriction]
		public NativeList<VoronoiPlane> VoronoiPlanes;

		public void Execute(int index)
		{
		}
	}
}
