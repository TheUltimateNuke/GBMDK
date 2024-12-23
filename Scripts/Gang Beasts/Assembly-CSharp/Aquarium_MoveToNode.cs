using UnityEngine;

public class Aquarium_MoveToNode : MonoBehaviour
{
	public Transform[] nodes;

	public float moveSpeed;

	public float forwardAlignmentStrength;

	public float verticalAlignmentStrength;

	public float maxNodeOffset;

	public float targetNodeDistace;

	public bool randomiseNodes;

	public Transform thisTransform;

	public Rigidbody thisRigidbody;

	private int currentNode;

	private Vector3 nodeOffset;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void GetNode(bool randomiseNodes)
	{
	}
}
