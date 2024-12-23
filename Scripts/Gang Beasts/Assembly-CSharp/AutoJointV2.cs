using System.Collections.Generic;
using UnityEngine;

public class AutoJointV2 : MonoBehaviour
{
	private enum State
	{
		Good = 0,
		Warning = 1,
		Failed = 2,
		Root = 3
	}

	public float searchRadius;

	private State goodState;

	private static List<Rigidbody> _collidersRigidbody;

	public Rigidbody GetConnecting()
	{
		return null;
	}

	public List<Rigidbody> FindRigidbodyNear()
	{
		return null;
	}

	public bool BuildJoints()
	{
		return false;
	}

	private void OnValidate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
