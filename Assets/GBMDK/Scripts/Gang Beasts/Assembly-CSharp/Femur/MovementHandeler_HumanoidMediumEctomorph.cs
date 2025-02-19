using UnityEngine;

namespace Femur
{
	public class MovementHandeler_HumanoidMediumEctomorph : MovementHandeler
	{
		public float airSpeed;

		public float _cycleModifer;

		public float cycleTimer;

		public float cycleSpeed;

		public Pose leftLegPose;

		public Pose rightLegPose;

		public Pose leftArmPose;

		public Pose rightArmPose;

		public float runForce;

		private static Vector3 runVectorForce10;

		private static Vector3 runVectorForce5;

		private static Vector3 runVectorForce2;

		private static Vector3 counterForce;

		public float swimCycleTimer;

		public float swimCycleSpeed;

		public Pose swimLeftLegPose;

		public Pose swimRightLegPose;

		public Pose swimLeftArmPose;

		public Pose swimRightArmPose;

		public override void HeadActionReadying()
		{
		}

		public override void HeadActionHeadbutting()
		{
		}

		public override void HeadActionResetting()
		{
		}

		public override void ArmActionReadying(Side side)
		{
		}

		public override void ArmActionPunching(Side side)
		{
		}

		public override void ArmActionElbowing(Side side)
		{
		}

		public override void ArmActionGrabbing(Side side)
		{
		}

		public override void ArmActionPunchResetting(Side side)
		{
		}

		public override void ArmActionElbowResetting(Side side)
		{
		}

		public override void ArmActionCheering()
		{
		}

		public override void Climb()
		{
		}

		public override void Dead()
		{
		}

		public override void Drive()
		{
		}

		public override void Emote()
		{
		}

		public override void Fall()
		{
		}

		public override void Idle()
		{
		}

		public override void Jump()
		{
		}

		public override void LegActionReadying(Side side)
		{
		}

		public override void LegActionKicking(Side side)
		{
		}

		public override void LegActionResetting(Side side)
		{
		}

		public override void Run()
		{
		}

		private void RunCycleUpdate()
		{
		}

		private void RunCyclePoseBody()
		{
		}

		private void RunCyclePoseArm(Side side, Pose pose)
		{
		}

		private void RunCyclePoseLeg(Side side, Pose pose)
		{
		}

		private void RunCycleRotateBall()
		{
		}

		public override void Stand()
		{
		}

		public override void Swim()
		{
		}

		private void SwimCycleUpdate()
		{
		}

		private void SwimCyclePoseBody()
		{
		}

		private void SwimCyclePoseArm(Side side, Pose pose)
		{
		}

		private void SwimCyclePoseLeg(Side side, Pose pose)
		{
		}

		public override void Unconscious()
		{
		}
	}
}
