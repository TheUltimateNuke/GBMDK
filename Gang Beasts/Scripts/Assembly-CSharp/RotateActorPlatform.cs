using Costumes;
using UnityEngine;

public class RotateActorPlatform : MonoBehaviour
{
	public CostumeCustomization CostumeCustomization;

	public Camera RaycastCamera;

	public float MouseTurnSpeed;

	public float ControllerTurnSpeed;

	public float MaxRotationSpeed;

	private float rotationTarget;

	private Ray _ray;

	private bool _trackingMouse;

	private Vector2 _previousMousePos;

	[SerializeField]
	private CapsuleCollider _startArea;

	[SerializeField]
	private float _startRange;

	[SerializeField]
	private Transform _rotationHelper;

	private Transform _rotationHelperRF;

	private Transform _rotationHelperLF;

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Turn(float rotation = 0f)
	{
	}
}
