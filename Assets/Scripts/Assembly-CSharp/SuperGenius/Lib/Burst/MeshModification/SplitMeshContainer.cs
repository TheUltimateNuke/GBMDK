using System;
using System.Collections.Generic;
using SuperGenius.Lib.Burst.Voronoi;
using UnityEngine;

namespace SuperGenius.Lib.Burst.MeshModification
{
	[Serializable]
	public class SplitMeshContainer
	{
		public bool IsValid;

		public GameObject SpawnedMesh;

		public MeshFilter MeshFilter;

		public Mesh mesh;

		public List<VoronoiPlane> Planes;
	}
}
