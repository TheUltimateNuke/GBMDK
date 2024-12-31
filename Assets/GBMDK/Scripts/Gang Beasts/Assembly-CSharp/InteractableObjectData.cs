using System;
using Femur;
using GB.Game.Critters;
using UnityEngine;

[Serializable]
public class InteractableObjectData
{
	public GameObject gameObject;

	public Collider mainCollider;

	public InteractableObject.Priority priorityModifier;

	public InteractableObject.Grab grabModifier;

	public InteractableObject.Damage damageModifier;

	public bool partOfRagdoll;

	public bool IgnoreValidate;

	public bool IgnoreStageHazards;

	public Transform cachedTransform;

	public Rigidbody cachedRigidbody;

	public Collider[] cachedColliders;

	public bool checkVelocity;

	public bool alwaysDrain;

	public bool movingPlatform;

	public bool triggerBudBud;

	public bool isCritterTarget;

	public bool isTentacle;

	public Actor actor;

	public BirdActor birdActor;

	public RatActor ratActor;

	public SharkActor sharkActor;

	public FishActor fishActor;

	public static InteractableObjectData CreateInstance(GameObject _gameObject, Collider _mainCollider, InteractableObject.Priority _priorityModifier, InteractableObject.Grab _grabModifier, InteractableObject.Damage _damageModifier, bool _partOfRagdoll, Transform _cachedTransform, Rigidbody _cachedRigidbody, Collider[] _cachedColliders, bool _checkVelocity, bool _alwaysDrain, bool _movingPlatform, bool _triggerBudBud, Actor _actor = null, bool _isCritterTarget = false, bool _isTentacle = false, BirdActor _birdActor = null, RatActor _ratActor = null, SharkActor _sharkActor = null, FishActor _fishActor = null)
	{
		return null;
	}

	public static InteractableObjectData GetFromTransform(Transform transform)
	{
		return null;
	}
}
