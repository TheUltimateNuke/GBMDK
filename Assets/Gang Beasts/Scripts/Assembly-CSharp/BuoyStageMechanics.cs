using System.Runtime.CompilerServices;
using CoreNet.StateSync.Syncs;
using GB.Environment.Breakable;
using UnityEngine;

public class BuoyStageMechanics : MonoBehaviour, IBreakable
{
	[SerializeField]
	private BuoyStageMechanics physicsIce;

	[SerializeField]
	private float centripicalForce;

	[SerializeField]
	private Transform centerTarget;

	[SerializeField]
	private Transform shark;

	[SerializeField]
	private bool canBreak;

	[SerializeField]
	private GeneralAudioData breakAudioData;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	private RigidbodySync sync;

	private bool _hasBroken;

	[HideInInspector]
	public bool sink;

	public ParticleSystem bubbles;

	public bool IsBroken => false;

	public event IBreakable.BreakableEvent OnBroken
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	private void FixedUpdate()
	{
	}

	[ContextMenu("Force break")]
	public void Break()
	{
	}

	public void PlayBreakIceAudio()
	{
	}

	public bool CanBreak()
	{
		return false;
	}

	public void SetSink(bool isSinking)
	{
	}

	private void ResetTag()
	{
	}

	private void OnDisable()
	{
	}
}
