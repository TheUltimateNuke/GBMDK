using System;
using UnityEngine;

namespace GB.View.Effects
{
	public abstract class Effect : MonoBehaviour
	{
		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public abstract void Play(Action callback, params object[] args);

		protected abstract string GetEffectKey();
	}
}
