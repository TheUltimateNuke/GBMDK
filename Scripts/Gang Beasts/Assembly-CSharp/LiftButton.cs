using UnityEngine;

public class LiftButton : MonoBehaviour
{
	public enum Action
	{
		Up = 0,
		Down = 1,
		Target = 2
	}

	public Action action;

	public Lift[] targetLifts;

	public int targetFloor;

	private bool ignoreCollisions;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void CheckCollisions()
	{
	}
}
