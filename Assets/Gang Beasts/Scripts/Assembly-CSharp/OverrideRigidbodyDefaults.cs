using UnityEngine;

public class OverrideRigidbodyDefaults : MonoBehaviour
{
	public bool overrideSolverIterations;

	public int solverIterations;

	public bool overrideSolverVelocityIterations;

	public int solverVelocityIterations;

	public bool overrideInertiaTensor;

	public float inertiaTensor;

	public bool overrideInertiaTensorRotation;

	public float inertiaTensorRotation;

	private void Start()
	{
	}
}
