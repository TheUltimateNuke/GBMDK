using UnityEngine;

public class VentsMechanics : MonoBehaviour
{
	public enum State
	{
		Stop = 0,
		Clockwise = 1,
		Anticlockwise = 2
	}

	public HingeJoint[] blades;

	public AudioClip[] bladeTurnSounds;

	public AudioClip startSound;

	public AudioClip stopSound;

	public AudioClip[] runningLoopSound;

	public ParticleSystem windEffect;

	private ParticleSystem.VelocityOverLifetimeModule windEffectVelocity;

	private ParticleSystem.EmissionModule windEffectEmission;

	public Rigidbody fanAxle;

	public State state;

	public State lastState;

	public float speed;

	private float delayTimer;

	private float spinDelay;

	private float bladeTurnAudioDelay;

	private float maxSpeed;

	public float spinUpSpeed;

	public float spinDownSpeed;

	private AudioSource runningLoopSource;

	private AudioSource startStopSoundSource;

	private AudioSource bladeSoundSource;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ToggleBladeDirrection()
	{
	}

	private void Spin(State state)
	{
	}
}
