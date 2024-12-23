using Audio;
using Femur;
using GB.Misc;
using UnityEngine;

public class RopeBreak : BaseCable
{
	private struct JointValueCache
	{
		public float cachedForce;

		public float cachedTorque;
	}

	public float health;

	public AudioClip[] impactSound;

	public AudioClip[] breakSound;

	public AudioMixerController.MixerGroup mixerGroup;

	private Rigidbody thisRigidbody;

	private Rigidbody otherRigidbody;

	[SerializeField]
	private Joint[] joints;

	private bool _invulnerable;

	private JointValueCache[] cachedJointValues;

	private Actor lastBeastHitRef;

	private bool Invulnerable => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameStarted()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnJointBreak()
	{
	}

	private void ResetTag()
	{
	}

	private void OnDisable()
	{
	}
}
