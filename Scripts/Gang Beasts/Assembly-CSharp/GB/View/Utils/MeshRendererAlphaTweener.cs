using System.Collections.Generic;
using UnityEngine;

namespace GB.View.Utils
{
	[RequireComponent(typeof(MeshRenderer))]
	public class MeshRendererAlphaTweener : MonoBehaviour
	{
		private enum TweenDirection
		{
			NONE = 0,
			IN = 1,
			OUT = 2
		}

		public float TweenSpeed;

		private const float FULL_ALPHA = 1f;

		private const float ZERO_ALPHA = 0f;

		private MeshRenderer _MeshRenderer;

		private TweenDirection _Direction;

		private Queue<TweenDirection> _DirectionQueue;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void TweenIn()
		{
		}

		public void TweenOut()
		{
		}

		public void EnqueueTweenIn()
		{
		}

		public void EnqueueTweenOut()
		{
		}

		private bool Tween()
		{
			return false;
		}

		private bool CheckQueue()
		{
			return false;
		}

		private bool ClampAlpha(ref float alpha)
		{
			return false;
		}

		private void SetAlpha(float alpha)
		{
		}
	}
}
