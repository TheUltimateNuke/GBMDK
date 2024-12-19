using Audio;
using Femur;
using GB.Misc;
using UnityEngine;

public class Gondola_Cable : BaseCable
{
	public float health;

	public AudioClip[] breakSound;

	public AudioMixerController.MixerGroup mixerGroup;

	private Joint thisJoint;

	[HideInInspector]
	public Rigidbody thisRigidbody;

	[SerializeField]
	private Actor lastBeastHitRef;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void PlayBreakSound()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnJointBreak()
	{
	}
}
