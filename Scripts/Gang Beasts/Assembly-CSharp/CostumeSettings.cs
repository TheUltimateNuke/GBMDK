using UnityEngine;

public class CostumeSettings : MonoBehaviour
{
	public bool ReduceUsingMesh;

	public int PartSize;

	public Transform CollidersRoot;

	public Collider[] KeepInColliders;

	public Collider[] KeepOutColliders;

	public Transform MeshOffset;
}
