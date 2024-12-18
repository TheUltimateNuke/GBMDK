using System.Collections.Generic;
using UnityEngine;

namespace GB.Game.Critters
{
	public class CritterEscalationManager : MonoBehaviour
	{
		public enum RouteType
		{
			Idle = 0,
			Wander = 1,
			Attacking = 2,
			Carrying = 3,
			Killing = 4
		}

		public LayerMask ActorLayerMask;

		public LayerMask EnvironmentLayerMask;

		[Header("General")]
		public float roundTime;

		public Vector3 ValidTargetExtents;

		public float RoundTimer;

		public AnimationCurve SpawnDelayWeighting;

		public AnimationCurve IdleToWanderWeight;

		public AnimationCurve AggressionScaling;

		public AnimationCurve AttackPlayerChance;

		public AnimationCurve AttackEnvironmentChance;

		public float IdleToWanderValue;

		[Header("Bird Config")]
		public bool useBirds;

		public BirdActor[] birds;

		public int CritterGrabLimiter;

		public float BirdStartingSearchDistance;

		public float BirdCollectiveAnger;

		public float BirdCollectiveSearchDistance;

		public float BirdAttackEnvironmentChance;

		public float BirdAttackPlayerChance;

		public LayerMask BirdTargetLayerMask;

		public MovementNode[] movementNodes;

		public MovementNode[] idleNodes;

		public MovementNode[] dropNodes;

		public float birdSpawnHeight;

		public float birdSpawnDistance;

		private int birdTriggerCounter;

		public float birdMinStartDelay;

		public float birdMaxStartDelay;

		[Range(0f, 100f)]
		public float birdDropOnTargetChance;

		public MovementNode start;

		public MovementNode end;

		private float birdStartDelay;

		private float ymin;

		private float ymax;

		private float xmin;

		private float xmax;

		private float zmin;

		private float zmax;

		private Dictionary<GameObject, AttackTargetTracker> AttackTargetTrackers;

		public void TestCase()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void GameStarted()
		{
		}

		private void SpawnBird()
		{
		}

		private void Update()
		{
		}

		public MovementNode RequestNode(RouteType routeType)
		{
			return null;
		}

		public MovementNode RequestClosestNodeOfType(RouteType routeType, Vector3 currentPos)
		{
			return null;
		}

		public bool FindNonActorTarget(Rigidbody MyRigidBody, float Range, out InteractableObjectData foundTarget)
		{
			foundTarget = null;
			return false;
		}

		public bool FindActorTarget(Rigidbody MyRigidBody, float Range, out InteractableObjectData foundTarget)
		{
			foundTarget = null;
			return false;
		}

		public void RegisterCritterTarget(GameObject targetToRegister)
		{
		}

		public MovementNode GetAttackTargetNode(Vector3 critterPos, GameObject target, bool KillTarget)
		{
			return null;
		}

		public void StopAttackingTarget(GameObject target)
		{
		}

		public bool TargetValid(Vector3 targetPos)
		{
			return false;
		}

		public List<MovementNode> BirdRouteToTargetRecursive(Vector3 startPosition, Vector3 targetPosition)
		{
			return null;
		}

		private MovementNode RequestClosestMovementNode(Vector3 position)
		{
			return null;
		}

		public List<MovementNode> BirdRouteToTarget(Vector3 startPosition, Vector3 targetPosition)
		{
			return null;
		}

		public List<MovementNode> BirdRouteToTarget(MovementNode startNode, Vector3 targetPosition)
		{
			return null;
		}

		public List<MovementNode> BirdRouteToTarget(Vector3 startPosition, MovementNode targetNode)
		{
			return null;
		}

		public List<MovementNode> BirdRouteToTarget(MovementNode startNode, MovementNode targetNode)
		{
			return null;
		}

		private List<MovementNode> BirdRouteNodeToNode(MovementNode startNode, MovementNode endNode)
		{
			return null;
		}

		private void RecursiveNodeSearch(ref List<MovementNode> resultList, ref float distanceToTarget, MovementNode nodeToCheck, Vector3 targetPosition)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
