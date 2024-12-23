using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Game.Gameplay
{
	public static class GameplayModifiers
	{
		public static float punchStrengthMul;

		public static float punchForceMul;

		public static float grabStrengthMul;

		public static float headScaleMul;

		public static float bodyScaleMul;

		public static float jumpForceMul;

		public static float moveSpeedMul;

		public static float damageTakenMul;

		public static float throwStrengthMul;

		public static bool isSticky;

		private static Vector3 _gravity;

		public static Vector3 gravity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public static event Action OnModifiersUpdate
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

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void ResetModifiers()
		{
		}

		public static void ApplyUpdates()
		{
		}
	}
}
