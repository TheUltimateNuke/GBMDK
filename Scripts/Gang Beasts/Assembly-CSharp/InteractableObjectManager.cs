using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObjectManager : MonoSingleton<InteractableObjectManager>
{
	public enum InteractableObjectSearchType
	{
		ActorTarget = 0,
		Actors = 1,
		CritterTarget = 2,
		TentacleTarget = 3,
		Grabbable = 4,
		DamageDealing = 5,
		BirdActors = 6,
		SharkActors = 7,
		FishActors = 8,
		RatActors = 9
	}

	[SerializeField]
	private List<InteractableObjectData> _allInteractableObjects;

	[SerializeField]
	private List<InteractableObjectData> _targetsForActors;

	[SerializeField]
	private Dictionary<InteractableObject.Priority, List<InteractableObjectData>> _targetsForActorsPriority;

	[SerializeField]
	private List<InteractableObjectData> _actors;

	[SerializeField]
	private List<InteractableObjectData> _targetsForCritters;

	[SerializeField]
	private List<InteractableObjectData> _targetsForTentacles;

	[SerializeField]
	private List<InteractableObjectData> _grabbableObjects;

	[SerializeField]
	private List<InteractableObjectData> _damageDealingObjects;

	[SerializeField]
	private List<InteractableObjectData> _birdActors;

	[SerializeField]
	private List<InteractableObjectData> _ratActors;

	[SerializeField]
	private List<InteractableObjectData> _sharkActors;

	[SerializeField]
	private List<InteractableObjectData> _fishActors;

	public List<InteractableObjectData> AllInteractableObjects => null;

	public List<InteractableObjectData> TargetsForActors => null;

	public Dictionary<InteractableObject.Priority, List<InteractableObjectData>> TargetsForActorsPriority => null;

	public List<InteractableObjectData> Actors => null;

	public List<InteractableObjectData> TargetsForCritters => null;

	public List<InteractableObjectData> TargetsForTentacless => null;

	public List<InteractableObjectData> GrabbableObjects => null;

	public List<InteractableObjectData> DamageDealingObjects => null;

	public List<InteractableObjectData> BirdActors => null;

	public List<InteractableObjectData> RatsActors => null;

	public List<InteractableObjectData> SharkActors => null;

	public List<InteractableObjectData> FishActors => null;

	public InteractableObjectData GetInteractableObjectFromTransform(Transform t, InteractableObjectSearchType searchType)
	{
		return null;
	}

	private void GetClosestEntryInList(out InteractableObjectData closestObj, List<InteractableObjectData> listToCheck, float searchDistance, bool useCollider = true, Vector3 searchOrigin = default(Vector3))
	{
		closestObj = null;
	}

	private void GetRandomEntryFromListWithinRange(out InteractableObjectData randomObj, List<InteractableObjectData> listToCheck, Vector3 searchOrigin, float searchDistance, bool useCollider = false)
	{
		randomObj = null;
	}

	public static void DirtyDistanceCheck(out float distance, Vector3 targetPos, bool useCollider = true, Collider col = null, Vector3 searchOrigin = default(Vector3))
	{
		distance = default(float);
	}

	public void GetRandomInteractableObjectWithinSetDistance(out InteractableObjectData randomObj, float searchDistance, InteractableObjectSearchType searchType, bool useCollider = true, Vector3 searchOrigin = default(Vector3))
	{
		randomObj = null;
	}

	public void GetClosestInteractableObjectAndPointInWorldSpace(out InteractableObjectData closestObj, float searchDistance, InteractableObjectSearchType searchType, bool useCollider = true, Vector3 searchOrigin = default(Vector3))
	{
		closestObj = null;
	}

	public List<InteractableObjectData> GetInteractableObjectsWithPriority(InteractableObject.Priority priority)
	{
		return null;
	}

	public void RegisterInteractableObjectAndChildren(InteractableObject obj)
	{
	}

	public void UnRegisterInteractableObjectAndChildren(InteractableObject obj)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void ClearAllLists()
	{
	}

	private void UnregisterInteractableData(InteractableObjectData data)
	{
	}

	private void RegisterInteractableObjectData(InteractableObjectData data)
	{
	}
}
