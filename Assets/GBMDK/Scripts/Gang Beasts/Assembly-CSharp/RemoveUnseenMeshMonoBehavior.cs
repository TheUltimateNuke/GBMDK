using System.Collections.Generic;
using Costumes;
using UnityEngine;

public class RemoveUnseenMeshMonoBehavior : MonoBehaviour
{
	public bool run;

	public GameObject RootMesh;

	public RemoveUnseenMesh RemoveUnseenMesh;

	public List<RemoveUnseenMesh.MeshiesToReduce> MeshiesToReduces;

	private List<RemoveUnseenMesh.MeshiesToReduce> CleanedMeshiesToReduces;

	private void Update()
	{
	}
}
