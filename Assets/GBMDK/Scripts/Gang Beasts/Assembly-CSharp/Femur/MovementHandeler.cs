using UnityEngine;

namespace Femur
{
	public class MovementHandeler
	{
		public enum EmoteType
		{
			Laugh = 0
		}

		public enum Side
		{
			Left = 0,
			Right = 1
		}

		public enum Pose
		{
			Bent = 0,
			Forward = 1,
			Straight = 2,
			Behind = 3
		}

		public Transform localTransform;

		public Actor actor;

		public float armCheeringForce;

		public bool stateChange;

		public float emoteTime;

		public EmoteType emoteType;

		public virtual void Dead()
		{
		}

		public virtual void Unconscious()
		{
		}

		public virtual void Stand()
		{
		}

		public virtual void Run()
		{
		}

		public virtual void Jump()
		{
		}

		public virtual void Fall()
		{
		}

		public virtual void Climb()
		{
		}

		public virtual void Swim()
		{
		}

		public virtual void Drive()
		{
		}

		public virtual void Idle()
		{
		}

		public virtual void HeadActionReadying()
		{
		}

		public virtual void HeadActionHeadbutting()
		{
		}

		public virtual void HeadActionResetting()
		{
		}

		public virtual void ArmActionReadying(Side side)
		{
		}

		public virtual void ArmActionElbowReadying(Side side)
		{
		}

		public virtual void ArmActionPunching(Side side)
		{
		}

		public virtual void ArmActionFlailing(Side side)
		{
		}

		public virtual void ArmActionElbowing(Side side)
		{
		}

		public virtual void ArmActionGrabbing(Side side)
		{
		}

		public virtual void ArmActionPunchResetting(Side side)
		{
		}

		public virtual void ArmActionElbowResetting(Side side)
		{
		}

		public virtual void ArmActionCheering()
		{
		}

		public virtual void Emote()
		{
		}

		public virtual void LegActionReadying(Side side)
		{
		}

		public virtual void LegActionKicking(Side side)
		{
		}

		public virtual void LegActionResetting(Side side)
		{
		}

		public void SetEmote(EmoteType type, float time)
		{
		}

		public void AlignToVector(Rigidbody part, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed)
		{
		}
	}
}
