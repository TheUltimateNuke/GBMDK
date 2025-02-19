using UnityEngine;

[ExecuteInEditMode]
public class JK3D : MonoBehaviour
{
	private const int kMaxMaterials = 8;

	[SerializeField]
	[ReadOnly]
	private JK3DAtlasMaterials atlasMaterials;

	public JK3DAtlasMaterial[] GetMaterialsForAtlasContaining(string toContain)
	{
		return null;
	}

	public JK3DAtlasMaterials GetAtlasMaterialsRaw()
	{
		return null;
	}

	public JK3DAtlasMaterial[] GetAllAtlasMaterials()
	{
		return null;
	}

	public void Merge(JK3D jk3d)
	{
	}

	public void AddMaterials(Material[] materials)
	{
	}

	public JK3DAtlasMaterial GetMaterialsWithName(string toContain)
	{
		return null;
	}
}
