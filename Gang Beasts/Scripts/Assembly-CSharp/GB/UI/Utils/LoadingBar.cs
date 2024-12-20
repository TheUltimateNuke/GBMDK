using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class LoadingBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public bool isPendingRetry;

			internal void _003CActivateRetryUIAndWait_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CActivateRetryUIAndWait_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingBar _003C_003E4__this;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CActivateRetryUIAndWait_003Ed__27(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[SerializeField]
		private Image _imageBackground;

		[SerializeField]
		private Image _imageFiller;

		[SerializeField]
		private Transform _targetScaler;

		[SerializeField]
		private GameObject _retryMessage;

		[SerializeField]
		private bool _fillX;

		[SerializeField]
		private bool _fillY;

		[SerializeField]
		private bool _filleZ;

		[SerializeField]
		private UnityEvent _onFinish;

		private Vector3 _startScale;

		private int _loadSteps;

		private Action _retryAction;

		private int _lastStep;

		private int _subStep;

		private int _totalSubSteps;

		public int LoadSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalSubSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void UpdateLoad(float amount)
		{
		}

		public void IncreaseStep()
		{
		}

		public void UpdateLoad(int step)
		{
		}

		public void IncreaseSubStep()
		{
		}

		public void UpdateSubLoad(int step)
		{
		}

		public void ActivateRetryUI(Action onRetry)
		{
		}

		[IteratorStateMachine(typeof(_003CActivateRetryUIAndWait_003Ed__27))]
		public IEnumerator ActivateRetryUIAndWait()
		{
			return null;
		}

		private void OnRetry()
		{
		}
	}
}
