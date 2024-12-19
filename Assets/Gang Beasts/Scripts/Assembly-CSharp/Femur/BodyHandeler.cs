using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace Femur
{
	public class BodyHandeler : MonoBehaviour
	{
		public delegate void ToggleRendererHandler();

		private Vector3 _headBaseScale;

		private Vector3 _bodyBaseScale;

		public static int SolverIterations;

		public static int SolverVelocityIterations;

		public Transform localTransform;

		public Actor actor;

		public Material headMaterial;

		public Material bodyMaterial;

		public NavMeshAgent agent;

		public ConfigurableJoint leftGrabJoint;

		public Transform leftGrabTransform;

		public Collider leftGrabCollider;

		public Rigidbody leftGrabRigidbody;

		public InteractableObjectData leftGrabInteractable;

		public ConfigurableJoint rightGrabJoint;

		public Transform rightGrabTransform;

		public Collider rightGrabCollider;

		public Rigidbody rightGrabRigidbody;

		public InteractableObjectData rightGrabInteractable;

		public bool hasSetup;

		public BodyPart Root;

		public BodyPart Head;

		public BodyPart Chest;

		public BodyPart Waist;

		public BodyPart Stomach;

		public BodyPart Hips;

		public BodyPart Crotch;

		public BodyPart LeftArm;

		public BodyPart LeftForarm;

		public BodyPart LeftHand;

		public BodyPart LeftThigh;

		public BodyPart LeftLeg;

		public BodyPart LeftFoot;

		public BodyPart RightArm;

		public BodyPart RightForarm;

		public BodyPart RightHand;

		public BodyPart RightThigh;

		public BodyPart RightLeg;

		public BodyPart RightFoot;

		public BodyPart Ball;

		public BodyPart Spring;

		public BodyPart MeshHead;

		public BodyPart MeshBody;

		public BodyPart Agent;

		public BodyPart CameraTarget;

		private Dictionary<Transform, BodyPart> TransformToBodyPartMap;

		public static event ToggleRendererHandler OnToggleRenderers
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

		private void Awake()
		{
		}

		protected void ApplyGameplayModifiers()
		{
		}

		public static BodyEnum BodyPartNameToEnum(string name)
		{
			return default(BodyEnum);
		}

		public BodyPart EnumToBodyPart(BodyEnum num)
		{
			return null;
		}

		public BodyEnum PartToEnum(Rigidbody body)
		{
			return default(BodyEnum);
		}

		private void OnDestroy()
		{
		}

		public virtual void Setup()
		{
		}

		private void SetupParts()
		{
		}

		public BodyPart GetBodyPart(Transform partTransform)
		{
			return null;
		}

		public virtual void SetupTransforms()
		{
		}

		public virtual void SetupRigidbodys()
		{
		}

		public virtual void SetupColliders()
		{
		}

		public virtual void SetupCollisionHandelers()
		{
		}

		public virtual void SetupRenderers()
		{
		}

		public virtual void DestroyMaterials()
		{
		}

		public virtual void SetSkinColor(Color _color)
		{
		}

		public static void ToggleRenderers()
		{
		}

		public Rigidbody[] GetAllRigidbodies()
		{
			return null;
		}

		public Transform[] GetAllTransforms()
		{
			return null;
		}

		public Collider[] GetAllColliders()
		{
			return null;
		}

		public InteractableObjectData[] GetAllInteractables()
		{
			return null;
		}

		public static Transform FindTransformViaName(Transform trans, string transformName)
		{
			return null;
		}

		public void ResetLeftGrab()
		{
		}

		public void ResetRightGrab()
		{
		}

		public void ResetAgent()
		{
		}

		private void SetRigidbodySolverIterations(Rigidbody rigidbody, int solverIterations, int solverVelocityIterations)
		{
		}

		public void SetSolverIterations(int solverIterations, int solverVelocityIterations)
		{
		}

		public void SetSolverIterations()
		{
		}
	}
}
