using Audio;
using UnityEngine;

public class Crane : MonoBehaviour
{
	public Transform craneTarget;

	[Space]
	public Rigidbody machineDeck;

	public Rigidbody mainJib;

	public Rigidbody pistonStart;

	public Rigidbody pistonMiddle;

	public Rigidbody pistonEnd;

	public Rigidbody armTip;

	public Rigidbody hook;

	public Rigidbody lowerHalf;

	[Space]
	public float movementDampening;

	[Space]
	public bool AllowAudio;

	public GeneralAudioData translateAudioData;

	public GeneralAudioData rotateAudioData;

	private AudioController.PooledAudioSource craneTranslateAudioSource;

	private AudioController.PooledAudioSource craneRotateAudioSource;

	[HideInInspector]
	public Quaternion targetRotation;

	[HideInInspector]
	public Vector3 targetPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateArmPosition()
	{
	}

	private void FixedUpdate()
	{
	}
}
