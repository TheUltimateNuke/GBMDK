using System.Collections.Generic;
using UnityEngine;

public class MovementNode : MonoBehaviour
{
	public enum NodeType
	{
		Idle = 0,
		Movement = 1,
		Drop = 2
	}

	public NodeType type;

	public float autoNodeMaxDistance;

	public float autoNodeRadius;

	public MovementNode[] adjacentNodes;

	public bool active;

	public float radius;

	public MovementNode closestMoveNode;

	public List<MovementNode> NodePathKeys;

	public List<MovementNode> NodePathValues;

	public Dictionary<MovementNode, MovementNode> pathWeights;

	private void Start()
	{
	}

	[ContextMenu("AutoConnectNodes")]
	public void AutoConnectNodes()
	{
	}

	[ContextMenu("RemoveNullRefs")]
	public void RemoveNullRefs()
	{
	}

	[ContextMenu("SetClosestMovementNode")]
	public void SetClosestMoveNode()
	{
	}

	[ContextMenu("OutputNodeList")]
	public void OutputNodeList()
	{
	}
}
