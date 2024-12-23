using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using Femur;
using UnityEngine;
using UnityEngine.InputSystem.Users;

public class CMVcamTargeter : MonoBehaviour
{
	public enum trackType
	{
		Single = 0,
		Gang = 1,
		All = 2
	}

	private enum OrbitDir
	{
		Left = -1,
		Right = 1
	}

	[CompilerGenerated]
	private sealed class _003CScaleRemotePlayers_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CMVcamTargeter _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

        public object Current => throw new NotImplementedException();

        [DebuggerHidden]
		public _003CScaleRemotePlayers_003Ed__54(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

	private CinemachineVirtualCamera _MyVcam;

	private GangBeastsGroupComposer _AimSettings;

	private CinemachineTransposer _transposer;

	private CinemachineOrbitalTransposer _OrbitalTransposer;

	private CMOffsets _CameraSettings;

	private CMTargetGroupPool _TargetGroups;

	private TargetGroupAndTrackingInfo _CurrentTargetGroup;

	private Transform _CurrentTarget;

	private CinemachineTargetGroup.Target _LocalBeast;

	private TargetGroupAndTrackingInfo _LocalBeastGroup;

	[Tooltip("When this object is not null it pauses regular gang tracking and looks at this instead (the Aim Target).")]
	public Transform TargetOverride;

	[Tooltip("When this object is not null it pauses regular gang tracking and follows this instead (the Body Target).")]
	public Transform FollowOverride;

	[Tooltip("Dolly in value which will override the current dolly in (Max Dolly in) when a winner is declared.")]
	[HideInInspector]
	public float WinnerDollyIn;

	[Tooltip("Time taken to interpolate to the WinnerDollyIn distance towards the target.")]
	[HideInInspector]
	public float WinnerZoomDuration;

	[Tooltip("Height Offset the camera will attempt to maintain from the target when orbiting.")]
	private int OrbitHeight;

	[Tooltip("Minimum orbit velocity, is doubled when pressed in the same direction twice.")]
	[HideInInspector]
	public float OrbitVel;

	private float _CurrentOrbitVel;

	private bool _OrbitEnabled;

	[HideInInspector]
	public trackType myTrackType;

	private bool _LoopingOrientations;

	private int _CurrentIndex;

	private Vector3 orbitRotation;

	private float _ArchivedDeadZoneHeight;

	private float _ArchivedDeadZoneWidth;

	private float _ArchivedSoftZoneHeight;

	private float _ArchivedSoftZoneWidth;

	private bool _DeadZonesDisabled;

	private AnimFloat animOffset;

	private Vector3 animStartFollow;

	[HideInInspector]
	public bool AllowFollow;

	private bool _CullingDistantPlayers;

	private bool _LateJoiners;

	private bool _Spectating;

	private bool _Initialized;

	private bool _RoundOver;

	private float timeout;

	private void Start()
	{
	}

	private void Setup()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void WinnerDeclared()
	{
	}

	private void OnLocalGroupDead(CinemachineTargetGroup.Target t)
	{
	}

	private void OnActorSetup(Actor actor)
	{
	}

	private void UpdateTarget()
	{
	}

	private void StartSpectating(Transform spectatingTarget = null)
	{
	}

	private void LocalCameraOptions()
	{
	}

	private void OnlineCameraOptions()
	{
	}

	private void HandleLateJoiners()
	{
	}

	public void SetCameraTarget(Transform target, bool follow)
	{
	}

	public void ClearCameraTarget()
	{
	}

	public void SetTrackingState(bool state)
	{
	}

	private void LookAtTarget()
	{
	}

	private void FollowTarget()
	{
	}

	[IteratorStateMachine(typeof(_003CScaleRemotePlayers_003Ed__54))]
	private IEnumerator ScaleRemotePlayers()
	{
		return null;
	}

	private void CycleTrackingWeight()
	{
	}

	private void ProcessPrevCameraInput()
	{
	}

	private void ProcessNextCameraInput()
	{
	}

	private void ProcessPlayerInput(in InputUser inputUser)
	{
	}

	public void GetOrientations()
	{
	}

	public void SetOrientation()
	{
	}

	private void ResetOrientation()
	{
	}

	private void CycleTrackingType()
	{
	}

	private void CycleTrackingTypeSpectator()
	{
	}

	private void CycleSpecificTargetInGroup(CinemachineTargetGroup Group, bool forward = true)
	{
	}

	public Transform GetSpectatingCurrentTarget()
	{
		return null;
	}

	private void SetSpectatingWeight()
	{
	}

	private void ProcessSpectatingInput()
	{
	}

	private bool TrackingLocalPlayers()
	{
		return false;
	}

	public Actor GetActorFromTransform(Transform target)
	{
		return null;
	}

	private void Orbit(float vel)
	{
	}

	private void SetOrbitVel(OrbitDir dir)
	{
	}

	private void HandleSpectating()
	{
	}

	private void ZoomOnWinners()
	{
	}

	public void DisableDeadZones()
	{
	}

	public void EnableDeadZones()
	{
	}
}
