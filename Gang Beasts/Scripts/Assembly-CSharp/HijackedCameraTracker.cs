using Femur;
using UnityEngine;

public class HijackedCameraTracker : MonoBehaviour
{
	public Actor[] actors;

	public Vector3 position;

	public Vector3 rotation;

	public float FOV;

	[Space]
	public bool track;

	public Vector3 offset;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void GetActors()
	{
	}
}
