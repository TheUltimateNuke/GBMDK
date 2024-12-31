using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.View.Effects
{
	public static class EffectsRegistry
	{
		public static Dictionary<string, Action<Action, object[]>> _Effects;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void Register(string key, Effect effect)
		{
		}

		public static void Deregister(string key, Effect effect)
		{
		}

		public static void Play(string key, Action callback = null, params object[] args)
		{
		}
	}
}
