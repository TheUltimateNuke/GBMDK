using UnityEngine;

public class UnseenMeshSettings : MonoBehaviour
{
	public bool ReduceMesh;

	public Renderer RendererWithMesh;

	public Transform Offset;

	public Collider[] KeepInColliders;

	public Collider[] KeepOutColliders;

	private Mesh _mesh;

	public void Start()
	{
	}

	public void Remove()
	{
	}

	public bool Validate()
	{
		return false;
	}
}
