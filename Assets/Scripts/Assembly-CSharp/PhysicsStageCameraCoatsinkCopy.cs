using UnityEngine;

public class PhysicsStageCameraCoatsinkCopy : MonoBehaviour
{
	public float updateFrequency;

	public Vector3 offset;

	public Vector3 targetsCenter;

	public float maxZoom;

	public float zoom;

	public Transform[] targets;

	private Transform cameraTransform;

	private Transform targetTransform;

	private Rigidbody cameraRigidbody;

	private Rigidbody targetRigidbody;

	private Vector3 lastLookAtPosition;

	private Vector3 velocity1;

	private Vector3 velocity2;

	public float smoothTime;

	public bool orbit;

	public float orbitSpeed;

	private bool toggle;

	public GameObject controlsScreen;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RefreshCameraTargets()
	{
	}

	private void UpdateCenter()
	{
	}

	private void UpdateZoom()
	{
	}

	private void UpdatePosition()
	{
	}
}
