using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteAlways]
public class AnimationSpline : MonoBehaviour
{
	public enum AnimationSplineClip
	{
		Run = 0,
		TurnLeft = 1,
		TurnRight = 2
	}

	[SerializeField]
	private GameObject TangentPrefab;

	[SerializeField]
	private GameObject NodePrefab;

	[SerializeField]
	private AnimationSplineScriptableObject data;

	private float editorDeltaTime;

	private double lastTimeSinceStartup;

	[SerializeField]
	private List<AnimationSplineNode> nodes;

	[SerializeField]
	private GameObject Actor;

	[SerializeField]
	private Material GhostMaterial;

	[SerializeField]
	private float stoppingDistance;

	[SerializeField]
	private float turnSpeed;

	private Animator ghostPreviewAnimator;

	private Animator actorAnimator;

	private int nextBezierPointIndex;

	private Vector3 nextBezierPoint;

	private int nextNodeIndex;

	private AnimationSplineNode nextNode;

	private AnimationSplineNode currentNode;

	private int currentBezierIndex;

	[FormerlySerializedAs("TestBezierData")]
	public BezierData CurrentBezierData;

	[SerializeField]
	private bool ClosedLoop;

	private bool closedLoopLastValue;

	private bool ActorNullLast;

	[SerializeField]
	private bool PingPong;

	private bool PingPongLastValue;

	private bool pingPongReverse;

	private bool isSetup;

	private AnimationSplineClip lastAnimationClip;

	public bool IsSetup()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	public void Reset()
	{
	}

	private int GetNewBezierCount()
	{
		return 0;
	}

	private void Init()
	{
	}

	public void ApplyNewInspectorValues()
	{
	}

	private void RemoveLeftoverCurves(bool forceRemove = false)
	{
	}

	public List<BezierData> GetBezierCurves()
	{
		return null;
	}

	private bool IsRunningFoward()
	{
		return false;
	}

	private Animator GetAnimator()
	{
		return null;
	}

	private GameObject GetActor()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public List<AnimationSplineNode> GetNodes()
	{
		return null;
	}

	private void IncrementNextBezierPoint()
	{
	}

	private void IncrementNode()
	{
	}

	private AnimationSplineClip GetCurrentAnimationClip()
	{
		return default(AnimationSplineClip);
	}

	private AnimationSplineClip GetNextAnimationClip()
	{
		return default(AnimationSplineClip);
	}

	private BezierData GetNextBezierData()
	{
		return null;
	}

	private int GetCurrentNodeIndex()
	{
		return 0;
	}

	private void EditorUpdate()
	{
	}

	private void CheckProgress()
	{
	}

	private void Update()
	{
	}

	private void SetEditorDeltaTime()
	{
	}

	private void CreateGhost()
	{
	}

	public void AddNode()
	{
	}

	public void RemoveNode()
	{
	}

	public void DuplicateSpline()
	{
	}

	public bool GetPingPongStatus()
	{
		return false;
	}
}
