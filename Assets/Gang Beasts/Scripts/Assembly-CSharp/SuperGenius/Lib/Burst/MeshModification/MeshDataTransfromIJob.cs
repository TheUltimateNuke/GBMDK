using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.MeshModification
{
	public struct MeshDataTransfromIJob : IJob
	{
		public MeshData MeshData;

		public float3 Position;

		public quaternion Rotation;

		public void Execute()
		{
		}
	}
}
