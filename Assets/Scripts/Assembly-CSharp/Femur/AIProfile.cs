using System;
using UnityEngine;

namespace Femur
{
	[CreateAssetMenu(fileName = "NewAIProfile", menuName = "Gang Beasts/AI/New Profile")]
	public class AIProfile : ScriptableObject
	{
		[Serializable]
		public class DifficultyCurve
		{
			public enum DifficultyCurveType
			{
				Constant = 0,
				Linear = 1,
				Custom = 2
			}

			[SerializeField]
			private DifficultyCurveType _curveType;

			[SerializeField]
			private AnimationCurve _curve;

			public float GetValue(float difficulty)
			{
				return 0f;
			}

			public DifficultyCurve(float constant)
			{
			}

			public void SetConstant(float constant)
			{
			}

			public DifficultyCurve(float beginningDifficulty, float endDifficulty)
			{
			}

			public void SetLinear(float beginningDifficulty, float endDifficulty)
			{
			}

			public DifficultyCurve(AnimationCurve curve)
			{
			}

			public void SetCustom(AnimationCurve curve)
			{
			}
		}

		private const int MAX_PLAYER_COUNT = 8;

		public DifficultyCurve _punchDelayModifier;

		public DifficultyCurve _liftTimerModiferr;

		public DifficultyCurve _aiForceFollowDistancer;

		public DifficultyCurve _reachDistance;

		public DifficultyCurve _punchFollowTime;

		public DifficultyCurve _moveSpeedModifer;

		public DifficultyCurve _punchForceModifer;

		public DifficultyCurve _punchDamageModifer;

		public DifficultyCurve _punchWindup;

		public DifficultyCurve _revivalStartTime;

		public DifficultyCurve _recievedDamageModifer;

		public void ProcessActor(Actor actor, int playerCount, float difficultyModifer)
		{
		}

		public float CalcuateDifficulty(int playerCount, float difficultyModifer)
		{
			return 0f;
		}

		public float CalculateDifficultyBasedValue(AnimationCurve value, float difficulty)
		{
			return 0f;
		}
	}
}
