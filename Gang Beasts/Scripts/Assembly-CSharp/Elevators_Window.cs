using UnityEngine;

public class Elevators_Window : MonoBehaviour
{
	[Range(0f, 100f)]
	public float chanceToOpen;

	public float startHeight;

	public float openAngle;

	public float closedAngle;

	public float speed;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	private void Start()
	{
	}
}
