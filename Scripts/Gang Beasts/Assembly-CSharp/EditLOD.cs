using UnityEngine;

public class EditLOD : MonoBehaviour
{
	public LODGroup group;

	private LOD[] lod;

	public float[] lodPercentage;

	[ContextMenu("Get LOD Group")]
	private void GetLODGroup()
	{
	}

	[ContextMenu("Set LOD Group")]
	private void SetLODGroup()
	{
	}
}
