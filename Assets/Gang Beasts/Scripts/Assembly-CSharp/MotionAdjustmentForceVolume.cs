using System.Collections.Generic;
using UnityEngine;

public class MotionAdjustmentForceVolume : MonoBehaviour
{
	public float modifier;

	private Rigidbody thisRigidbody;

	private Vector3 currentVelocity;

	private Vector3 lastPosition;

	private List<Rigidbody> rbsInTrigger;

	private GameObject lastPosTracker;

	private bool run;

	private void Start()
	{
	}

	private void RunThis()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void OnTriggerExit(Collider collider)
	{
	}
}
