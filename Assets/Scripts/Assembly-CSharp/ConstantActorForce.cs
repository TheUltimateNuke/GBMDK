using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class ConstantActorForce : MonoBehaviour
{
	public Vector3 ForcePerSecond;

	public Vector3 ForceTarget;

	public bool OnlyActors;

	public bool AddSpin;

	private void OnTriggerStay(Collider other)
	{
	}

	private float FindChange(float currentValue, float targetValue, float changeAmount)
	{
		return 0f;
	}
}
