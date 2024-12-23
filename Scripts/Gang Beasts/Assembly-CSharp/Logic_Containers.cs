using UnityEngine;

public class Logic_Containers : MonoBehaviour
{
	public enum State
	{
		idle = 0,
		rotateLeft = 1,
		rotateRight = 2
	}

	public float stateChangeDelayMin;

	public float stateChangeDelayMax;

	public float forceMin;

	public float forceMax;

	public Rigidbody crainARigidbody;

	public State crainAState;

	public float crainAForce;

	public Rigidbody crainBRigidbody;

	public State crainBState;

	public float crainBForce;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ChangeCrainAState()
	{
	}

	private void ChangeCrainBState()
	{
	}
}
