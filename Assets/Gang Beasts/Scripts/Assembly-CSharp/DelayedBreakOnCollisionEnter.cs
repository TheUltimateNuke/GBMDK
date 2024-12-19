using CoreNet.StateSync.Triggers;
using UnityEngine;
using UnityEngine.Audio;

public class DelayedBreakOnCollisionEnter : MonoBehaviour
{
	public AnimationCurve delay;

	public float minDelayTime;

	public float maxDelayTime;

	public DelayedBreakOnCollisionEnter[] otherDelayedBreaksToTrigger;

	public GeneralAudioData creakingSounds;

	public AudioClip[] breakingAudioClips;

	public AudioMixerGroup mixerGroup;

	private bool hasTriggered;

	private Joint[] joints;

	private BaseSyncTrigger[] triggers;

	private bool ready;

	private Rigidbody thisRigidbody;

	public Material changeCol;

	public MeshRenderer debugTarget;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void DelayGetJoints()
	{
	}

	private void BreakJoints()
	{
	}
}
