using UnityEngine;

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class ImageEffectBase : MonoBehaviour
{
	public Shader shader;

	private Material m_Material;

	protected Material material => null;

	protected virtual void Start()
	{
	}

	protected virtual void OnDisable()
	{
	}
}
