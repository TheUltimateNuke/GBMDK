using UnityEngine;

public class Road : MonoBehaviour
{
	public Transform start;

	public Transform end;

	public float speed;

	public MeshFilter BackgroundObject;

	private Rigidbody _CachedRigidbody;

	public Mesh[] roadModels;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
