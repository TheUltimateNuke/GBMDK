using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
	public Transform targetTransform;

	private Rigidbody thisRigidbody;

	private Vector3 targetPosition;

	private Transform thisTransform;

	private ConfigurableJoint thisJoint;

	[SerializeField]
	private Vector3 _restTarget;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
	{
	}

	public Vector3 GetTargetPosition()
	{
		return default(Vector3);
	}
}
