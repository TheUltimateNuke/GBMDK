using System.Collections.Generic;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace SuperGenius.Lib.Burst.MeshModification
{
	public class SplitMeshJob
	{
		public MeshData _meshData;

		public List<MeshData> _newMesh;

		private List<NativeArray<SuperGenius.Lib.Burst.Geometry.Plane>> _planLists;

		private Material[] _mats;

		private Material _innerMat;

		private List<SplitMeshContainer> _splitMeshContainers;

		public JobHandle CreateJob(Mesh mesh, Material[] mats, List<SplitMeshContainer> edges, bool centerPivot = false, int innerMaterialIndex = 0)
		{
			return default(JobHandle);
		}

		public JobHandle CreateJob(ref MeshData mesh, Material[] mats, List<SplitMeshContainer> edges, bool centerPivot = false, int innerMaterialIndex = 0)
		{
			return default(JobHandle);
		}

		public void SpawnMeshes(Transform parent)
		{
		}

		public void SpawnMeshes(GameObject prefab, Transform parent)
		{
		}

		public void SpawnMeshes()
		{
		}

		public void BuildMeshes()
		{
		}

		private void SpawnMesh(GameObject go, int meshIndex)
		{
		}

		public void Dispose()
		{
		}
	}
}
