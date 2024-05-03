using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class OnGrabSetMass : MonoBehaviour
{
	public float GrabMass;

	public List<OnGrabSetMass> SetMassList;

	public GrabEvent GrabEvent;

	private bool _isGrabed;

	private Rigidbody _rigidbody;

	private float _rigibodyDefaultMass;

	private void Awake()
	{
	}

	private void OnGrab()
	{
	}

	private void OnRelease()
	{
	}

	private void SetGrabMass()
	{
	}

	private void SetDefaultMass()
	{
	}

	private void OnDestroy()
	{
	}
}
