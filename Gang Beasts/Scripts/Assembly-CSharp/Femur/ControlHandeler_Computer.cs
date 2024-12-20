using UnityEngine;

namespace Femur
{
	public class ControlHandeler_Computer : ControlHandeler
	{
		public float _punchFollowTime;

		public float _punchFollowDistance;

		public float _punchreachDistance;

		private float _stuckTimer;

		private const float STUCK_TIMER_MAX = 2f;

		private const float AGENT_MAX_DIST_FROM_ACTOR = 1f;

		private new float fallTimer;

		private float legActionDelay;

		private float legActionTimer;

		private Collider leftKickTarget;

		private Collider rightKickTarget;

		private float leftKickTimer;

		private float rightKickTimer;

		public float _liftTimerModifier;

		public float _liftModifier;

		public float _windupTime;

		public float _punchTime;

		public float _resetPunchTime;

		public float _punchDelayModifer;

		private float armActionDelay;

		private float leftArmActionTimer;

		private float rightArmActionTimer;

		private float leftPunchTimer;

		private float rightPunchTimer;

		private int time;

		public override void ClimbCheck()
		{
		}

		public override void DirectionCheck()
		{
		}

		private void ClampAgentDistance()
		{
		}

		private void UpdateAgentDestination()
		{
		}

		private void UpdateAgentDirection()
		{
		}

		public override void DuckCheck()
		{
		}

		public override void FallCheck()
		{
		}

		public override void GroundCheck()
		{
		}

		public override void JumpRunCheck()
		{
		}

		public void Jump()
		{
		}

		public override void KickStompCheck()
		{
		}

		public override void LiftCheck()
		{
		}

		public override void PunchGrabCheck()
		{
		}

		private void LeftPunchGrabCheck()
		{
		}

		private void RightPunchGrabCheck()
		{
		}

		public override void ResetVariables()
		{
		}

		public override void ReviveCheck()
		{
		}

		public override void RunCheck()
		{
		}

		public override void SwimCheck()
		{
		}
	}
}
