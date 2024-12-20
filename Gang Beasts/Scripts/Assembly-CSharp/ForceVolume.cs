using UnityEngine;

public class ForceVolume : MonoBehaviour
{
	[SerializeField]
	private float maxLifetime;

	private Transform thisTransform;

	private GameObject thisGameObject;

	private float currentLifetime;

	public bool outwards;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
