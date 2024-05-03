using UnityEngine;

public class InteractableObject : MonoBehaviour
{
	public enum Priority
	{
		Ignore = 0,
		Lowest = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		Highest = 5,
		Forced = 6
	}

	public enum Damage
	{
		Ignore = 0,
		Default = 1,
		Object = 2,
		Punch = 3,
		Kick = 4,
		DivingKick = 5,
		Headbutt = 6,
		DivingHeadbutt = 7,
		Knockout = 8,
		Special_Road = 9,
		Special_Train = 10,
		DamageVolume = 11
	}

	public enum Grab
	{
		Ignore = 0,
		Break = 1,
		DrainSlow = 2,
		DrainMedium = 3,
		DrainFast = 4,
		Perminant = 5
	}

	public Priority priorityModifier;

	public Grab grabModifier;

	public Damage damageModifier;

	[Tooltip("Enable if the rigidbody is part of a ragdoll (This is a workaround for the extra force thats required to lift a ragdoll)")]
	public bool partOfRagdoll;

	[HideInInspector]
	public Transform cachedTransform;

	[HideInInspector]
	public Rigidbody cachedRigidbody;

	[HideInInspector]
	public Collider cachedCollider;

	public bool checkVelocity;

	public bool alwaysDrain;

	[Tooltip("Enable if we want to trigger the budbud voice effect if held")]
	public bool triggerBudBud;

	[HideInInspector]
	public static float offset;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	public void CheckVelocity()
	{
	}
}
