using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace SuperGenius.Lib.Burst.MeshModification
{
	[BurstCompile]
	public struct SplitMeshIJob : IJob
	{
		[Unity.Collections.ReadOnly]
		public NativeArray<Plane> Planes;

		[Unity.Collections.ReadOnly]
		public MeshData MeshToCut;

		[Unity.Collections.ReadOnly]
		public int InternalMatIndex;

		public MeshData CutMesh;

		public void Execute()
		{
		}
	}
}
