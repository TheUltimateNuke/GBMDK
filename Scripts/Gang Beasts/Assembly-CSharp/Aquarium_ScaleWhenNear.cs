using UnityEngine;

public class Aquarium_ScaleWhenNear : MonoBehaviour
{
	public Transform thisTransform;

	public float scaleSpeed;

	public float startScale;

	public float endScale;

	private bool scale;

	private void FixedUpdate()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
