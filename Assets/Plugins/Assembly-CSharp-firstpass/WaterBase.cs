using UnityEngine;

[ExecuteInEditMode]
public class WaterBase : MonoBehaviour
{
	public Material sharedMaterial;

	public WaterQuality waterQuality;

	public bool edgeBlend;

	public void UpdateShader()
	{
	}

	public void WaterTileBeingRendered(Transform tr, Camera currentCam)
	{
	}

	public void Update()
	{
	}
}
