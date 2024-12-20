using UnityEngine;

public class WindEscalation : MonoBehaviour
{
	public EscalationSystem escalationSystem;

	[Space]
	public float defaultWindModifier;

	public float minorWindModifier;

	public float majorWindModifier;

	public float finalWindModifier;

	[Space]
	public Vector3 gravity;

	public Vector3 windDirection;

	public float minWindChangeDelay;

	public float maxWindChangeDelay;

	private void Start()
	{
	}

	private void ChangeWindDirection()
	{
	}

	private void Update()
	{
	}
}
