using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace SuperGenius.Lib.Burst.MeshModification
{
	[BurstCompile]
	public struct MeshData
	{
		public NativeList<float3> Verts;

		public NativeList<float3> Norms;

		public NativeList<float2> UVs;

		public NativeList<float3> BoundryEdges;

		public int SubIndexCount;

		public NativeList<int> SubIndex0;

		public NativeList<int> SubIndex1;

		public NativeList<int> SubIndex2;

		public NativeList<int> SubIndex3;

		public NativeList<int> SubIndex4;

		public NativeList<int> SubIndex5;

		public NativeList<int> SubIndex6;

		public NativeList<int> SubIndex7;

		public NativeList<int> SubIndex8;

		public NativeList<int> SubIndex9;

		public NativeList<int> SubIndex10;

		public NativeArray<float3> Offset;

		public MeshData(int vertCount, Allocator allocator, int subIndexCount = 1) : this()
        {
		}

		public MeshData(Mesh mesh, Allocator allocator) : this()
        {
		}

		public void SetSubIndexCount(int count)
		{
		}

		public void AddSubMeshIndex(int submesh, int value)
		{
		}

		public int GetSubMeshIndexLength(int submesh)
		{
			return 0;
		}

		public int GetSubMeshIndexValue(int submesh, int index)
		{
			return 0;
		}

		public bool isValid()
		{
			return false;
		}

		public Mesh GetMesh()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}
	}
}
