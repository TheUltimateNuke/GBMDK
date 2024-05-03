using Audio;
using Femur;
using GB.Misc;
using UnityEngine;

public class Elevators_Cable : BaseCable
{
	public enum Side
	{
		Left = 0,
		Right = 1
	}

	[SerializeField]
	private float _health;

	public Elevators_Car car;

	public Side side;

	public AudioClip[] breakSound;

	public AudioMixerController.MixerGroup output;

	public VolumeLevels.SoundType breakSound_soundType;

	private SceneAudioClip audioSource;

	private Joint thisJoint;

	[HideInInspector]
	public Rigidbody thisRigidbody;

	private Actor lastBeastHitRef;

	public float Health
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void PlayBreakSound()
	{
	}

	public void PlaySound(int sound, float pitch)
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
