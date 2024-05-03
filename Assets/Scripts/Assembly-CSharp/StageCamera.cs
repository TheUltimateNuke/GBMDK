using UnityEngine;

public class StageCamera : MonoBehaviour
{
	public float updateFrequency;

	public Vector3 offset;

	private Vector3 lastOffset;

	public Vector3 targetsCenter;

	public float maxZoom;

	public float zoom;

	public Transform[] targets;

	private Transform thisTransform;

	private Vector3 lastLookAtPosition;

	private Vector3 velocity1;

	private Vector3 velocity2;

	public float smoothTime;

	public bool orbit;

	public float orbitSpeed;

	private bool toggle;

	public GameObject controlsScreen;

	public Vector3 lookAtPosition;

	public Vector3 cameraPosition;

	public bool initialized;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void RefreshCameraTargets()
	{
	}

	private void UpdateCamera()
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

	private void SetPosition()
	{
	}
}
