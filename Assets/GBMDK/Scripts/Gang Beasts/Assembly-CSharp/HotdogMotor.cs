using UnityEngine;

public class HotdogMotor : MonoBehaviour
{
	public float forceStep;

	public float currentForce;

	public Rigidbody targetRigidbody;

	private void OnTriggerEnter(Collider collider)
	{
	}
}
