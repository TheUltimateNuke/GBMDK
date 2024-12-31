using System;
using UnityEngine;

namespace GB.View.Effects
{
	[ExecuteInEditMode]
	public class Fade : Effect
	{
		public delegate void OnFadeCreated(Fade fade);

		public Color Color;

		public static OnFadeCreated onFadeCreatedDel;

		private float Amount;

		private AnimationCurve _AnimationCurve;

		private AnimFloat _FloatAnim;

		private Material _Material;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void ForceFadeToValue(float val)
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected override string GetEffectKey()
		{
			return null;
		}

		public override void Play(Action callback, params object[] args)
		{
		}

		private void PlayFade(float fadeTime, float from, float to, Action callback)
		{
		}
	}
}
