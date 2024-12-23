using UnityEngine;

public class PhysicsAudioData : ScriptableObject
{
	public float enableCooldownDelay;

	public float softTriggerThreshold;

	public float hardTriggerThreshold;

	public float softImpactVolumeModifier;

	public float hardImpactVolumeModifier;

	public float minSoftImpactPitchModifier;

	public float maxSoftImpactPitchModifier;

	public float minHardImpactPitchModifier;

	public float maxHardImpactPitchModifier;

	public AudioClip[] softDirectImpactSound;

	public AudioClip[] hardDirectImpactSound;
}
