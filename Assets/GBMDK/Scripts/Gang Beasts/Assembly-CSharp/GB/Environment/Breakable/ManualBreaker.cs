using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CoreNet.Objects;
using UnityEngine;

namespace GB.Environment.Breakable
{
	public class ManualBreaker : MonoBehaviour, IBreakable
	{
		[SerializeField]
		private float _breaksPerMinMin;

		[SerializeField]
		private float _breaksPerMinMax;

		private float _breakTimer;

		private float _breakSecondsMin;

		private float _breakSecondsMax;

		[SerializeField]
		private List<MonoBehaviour> _iBreakablesCache;

		private List<IBreakable> _iBreakables;

		private bool _gameStarted;

		public bool TimeBroken => false;

		public bool IsBroken => false;

		public IBreakable this[int index] => null;

		public event IBreakable.BreakableEvent OnBroken
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void GameStateCheck(NetInt newState)
		{
		}

		private void Update()
		{
		}

		public void Break()
		{
		}

		public void BreakPoint(int index)
		{
		}

		private void OnSubBroken(IBreakable brokenObject, object info)
		{
		}

		[ContextMenu("Get lower breakables")]
		private void FindChildBreakables()
		{
		}

		private void OnValidate()
		{
		}
	}
}
