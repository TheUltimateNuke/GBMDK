using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Voronoi
{
	[BurstCompile]
	public struct BuildVoronoiCells : IJob
	{
		[Unity.Collections.ReadOnly]
		public NativeList<float3> Locations;

		[WriteOnly]
		public NativeList<VoronoiPlane> Planes;

		public void Execute()
		{
		}
	}
}
