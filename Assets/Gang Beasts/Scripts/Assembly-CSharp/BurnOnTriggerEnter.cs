using System.Collections.Generic;
using Femur;
using UnityEngine;

public class BurnOnTriggerEnter : MonoBehaviour
{
	public ParticleSystem fireParticle;

	public ParticleSystem smokeParticle;

	public GeneralAudioData igniteAudioData;

	public GeneralAudioData burningAudioData;

	public List<Actor> burningActors;

	public List<float> triggerDelays;

	[Range(0f, 100f)]
	public float chanceToSpread;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider collider)
	{
	}

	private void Ignite(Actor hitActor)
	{
	}

	private void FixedUpdate()
	{
	}
}
