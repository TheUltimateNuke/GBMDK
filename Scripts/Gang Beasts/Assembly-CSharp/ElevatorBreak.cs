using UnityEngine;

public class ElevatorBreak : MonoBehaviour
{
	public Lift lift;

	public int cable;

	public Rigidbody[] items;

	public Rigidbody rootItem;

	public float health;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void SetBroken()
	{
	}

	private void OnJointBreak(float force)
	{
	}
}
