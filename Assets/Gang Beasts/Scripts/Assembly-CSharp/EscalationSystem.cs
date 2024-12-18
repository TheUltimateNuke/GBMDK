using UnityEngine;

public class EscalationSystem : MonoBehaviour
{
	public enum Escalation
	{
		none = 0,
		minor = 1,
		major = 2,
		final = 3
	}

	public bool canEscalate;

	[Space]
	public float timer;

	public Escalation status;

	[Space]
	public float minMinorTriggerTime;

	public float maxMinorTriggerTime;

	[Space]
	public float minMajorTriggerTime;

	public float maxMajorTriggerTime;

	[Space]
	public float minFinalTriggerTime;

	public float maxFinalTriggerTime;

	[HideInInspector]
	public float minorTriggerTime;

	[HideInInspector]
	public float majorTriggerTime;

	[HideInInspector]
	public float finalTriggerTime;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
