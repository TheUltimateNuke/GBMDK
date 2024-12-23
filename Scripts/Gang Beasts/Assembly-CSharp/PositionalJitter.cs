using UnityEngine;

public class PositionalJitter : MonoBehaviour
{
	public Vector3 Range;

	public float MinimumInterval;

	public float MaximumInterval;

	public AnimationCurve JitterCurve;

	private Vector3 anchorPosition;

	private Vector3 currentJitterTarget;

	private Vector3 lastJitterTarget;

	private float nextJitterTime;

	private float currentJitterInterval;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
