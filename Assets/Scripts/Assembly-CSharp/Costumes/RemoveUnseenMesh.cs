using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class RemoveUnseenMesh
	{
		[Serializable]
		public class MeshiesToReduce
		{
			public GameObject[] GameObjects;

			public MeshiesToReduce(GameObject[] gameObjects)
			{
			}

			private void BuildMeshiesToReduce(GameObject[] gameObjects)
			{
			}
		}

		public bool UseAvroagedNormails;

		public bool AvroageTwordsCenterBounds;

		public int ReduceHiddenFaces;

		public float RaycastDistance;

		public float RayInnerOffset;

		public string LayerName;

		public bool DestroyKeepInOutRoot;

		public string KeepIn;

		public bool DebugRay;

		public bool DebugDontDestory;

		public float DebugRayTime;

		public static float PoisionOffsetY;

		public static int ObjectsToReduce;

		public static int ObjectsReduced;

		public Vector3 BaseMeshRotationOffset;

		public static GameObject RootGameObject;

		private int totalLevels;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void RemoveUneseenMeshs(List<MeshiesToReduce> meshiesToReduces, GameObject rootMesh = null)
		{
		}

		public void RunThourghSkinnedMeshRenderes(List<GameObject[]> skinnedMeshObjectsList)
		{
		}

		private void cleanMeshies(GameObject rootGameObject, List<GameObject> gameObjectsToReduce)
		{
		}

		private void RemoveUnseenFaces(List<GameObject> gameObjects, int layer)
		{
		}

		private static int[] CreateNewTriangles(bool[] selected, int[] triangles)
		{
			return null;
		}

		private bool[] reduceTrianglesSelection(int growBy, bool[] selected, int[] triangles)
		{
			return null;
		}

		private bool[] UnseenFaces(GameObject go, Vector3[] verts, Vector3[] normals, int layer)
		{
			return null;
		}

		private Vector3[] getAvroagedNormals(int[] triangles, Mesh mesh)
		{
			return null;
		}

		private Vector3[] getAvroagedNormalsTwordsCenterBounds(int[] triangles, Mesh mesh)
		{
			return null;
		}
	}
}
