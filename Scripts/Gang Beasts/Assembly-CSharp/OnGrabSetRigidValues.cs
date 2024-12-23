using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody))]
public class OnGrabSetRigidValues : MonoBehaviour
{
	public float GrabMass;

	public Vector3 GrabInertia;

	public bool SetInertia;

	[FormerlySerializedAs("SetMassList")]
	public List<OnGrabSetRigidValues> SetValuesList;

	public GrabEvent GrabEvent;

	private bool _isGrabed;

	private Rigidbody _rigidbody;

	private float _rigibodyDefaultMass;

	private Vector3 _rigidbodyDefaultInertia;

	private void Awake()
	{
	}

	private void OnGrab()
	{
	}

	private void OnRelease()
	{
	}

	private void SetGrabValues()
	{
	}

	private void SetDefaultValues()
	{
	}

	private void OnDestroy()
	{
	}
}
