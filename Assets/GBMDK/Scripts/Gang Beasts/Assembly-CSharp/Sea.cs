using UnityEngine;
using UnityEngine.Serialization;

public class Sea : MonoBehaviour
{
	public Texture2D[] normals;

	[FormerlySerializedAs("renderer")]
	public Renderer seaRenderer;

	public float speed;

	private int counter;

	private void Start()
	{
	}

	private void UpdateNormal()
	{
	}
}
