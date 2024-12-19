using System.Collections;
using UnityEngine;

namespace DG.Tweening.Core
{
	[AddComponentMenu(null)]
	public class DOTweenComponent : MonoBehaviour, IDOTweenInit
	{
		public int inspectorUpdater;

		private float _unscaledTime;

		private float _unscaledDeltaTime;

		private bool _duplicateToDestroy;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnLevelWasLoaded()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			return null;
		}

		internal IEnumerator WaitForCompletion(Tween t)
		{
			return null;
		}

		internal IEnumerator WaitForRewind(Tween t)
		{
			return null;
		}

		internal IEnumerator WaitForKill(Tween t)
		{
			return null;
		}

		internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			return null;
		}

		internal IEnumerator WaitForPosition(Tween t, float position)
		{
			return null;
		}

		internal IEnumerator WaitForStart(Tween t)
		{
			return null;
		}

		internal static void Create()
		{
		}

		internal static void DestroyInstance()
		{
		}
	}
}
