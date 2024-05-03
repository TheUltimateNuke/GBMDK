using Femur;
using UnityEngine;

public class CMTargetObject : MonoBehaviour
{
	[HideInInspector]
	public Actor Actor;

	public Transform _ToTrack;

	private Vector3 _Velocity;

	private Vector3 _MoveToPosition;

	[SerializeField]
	private float _SmoothTime;

	[SerializeField]
	private float _DeadZone;

	public float nonhumanWeighting;

	public float nonhumanRadius;

	private CMTrackedObject _trackedObject;

	[HideInInspector]
	public bool UpdateTarget;

	[SerializeField]
	private bool _onlyEnabled;

	private CMTrackedObject TrackedObject => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Actor_OnGangIDUpdated(int newID)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
