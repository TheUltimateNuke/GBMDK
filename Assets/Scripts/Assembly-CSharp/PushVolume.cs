using System.Collections.Generic;
using Femur;
using GB;
using UnityEngine;

public class PushVolume : MonoBehaviour
{
	public bool ActorVolume;

	public bool PushDeadBeasts;

	public bool PushKOBeasts;

	public bool ApplyAtBounds;

	public bool AnimatedElsewhere;

	protected Vector3 targetPushForce;

	public Vector3 pushDirection;

	public bool useRelativeDirection;

	[SerializeField]
	protected bool isActive;

	private Transform _thisTransform;

	private float lerpFactor;

	public List<PushVolumeClient> props;

	protected List<ActorComponentCache> actorRBs;

	protected Collider col;

	protected BodyEnum[] actorEnumValues;

	protected Transform ThisTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected virtual void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void RegisterActorRBs(Actor actor)
	{
	}

	public void UnregisterActorRBs(Actor actor)
	{
	}

	private void Update()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void ApplyForce(Rigidbody rb, Transform t, PushVolumeClient client)
	{
	}

	private void ApplyForces()
	{
	}

	private List<Rigidbody> GetActorRBs(Actor actor)
	{
		return null;
	}

	public void Activate()
	{
	}

	public void Activate(Vector3 newForce)
	{
	}

	public void Deactivate()
	{
	}

	protected void CollectBounds(out Vector3[] boundStorage, Rigidbody rb)
	{
		boundStorage = null;
	}
}
