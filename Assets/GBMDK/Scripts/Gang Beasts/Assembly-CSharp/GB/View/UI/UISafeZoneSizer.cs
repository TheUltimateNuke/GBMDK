using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.View.UI
{
	public class UISafeZoneSizer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateTargetOffsets_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UISafeZoneSizer _003C_003E4__this;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CUpdateTargetOffsets_003Ed__8(int _003C_003E1__state)
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
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private RectTransform _parent;

		[SerializeField]
		private Vector2 _insetAmount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformEvents_OnPlatformGamePauseEvent(bool effect)
		{
		}

		private void OnEnable()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTargetOffsets_003Ed__8))]
		private IEnumerator UpdateTargetOffsets()
		{
			return null;
		}
	}
}
