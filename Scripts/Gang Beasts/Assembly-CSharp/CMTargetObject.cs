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

	[SerializeField]
	private float _ScoreScreenSmoothTime;

	[SerializeField]
	private float _ScoreScreenDeadZone;

	private float _smoothTimeToUse;

	private float _deadZoneToUse;

	public float nonhumanWeighting;

	public float nonhumanRadius;

	private CMTrackedObject _trackedObject;

	[HideInInspector]
	public bool UpdateTarget;

	[SerializeField]
	private bool _onlyEnabled;

	private bool _coinScreenShowing;

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

	private void OnCoinScreenShow()
	{
	}

	private void OnCoinScreenHide()
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
