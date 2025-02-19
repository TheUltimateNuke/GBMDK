using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Costumes
{
	public class MatchHeadBendshapes : MonoBehaviour
	{
		[Serializable]
		public class BlendPartialName
		{
			public string ThisBlendName;

			public string HeadName;
		}

		[CompilerGenerated]
		private sealed class _003CFindHeadSkinnedMeshRenderer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MatchHeadBendshapes _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CFindHeadSkinnedMeshRenderer_003Ed__10(int _003C_003E1__state)
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

		public string HeadSkrGoName;

		public int RetryFindTimes;

		public float TimeInbetweenRetrys;

		public SkinnedMeshRenderer HeadSkm;

		public SkinnedMeshRenderer ThisSkm;

		public BlendPartialName[] BlendPartialNames;

		public int[] _blendshaps;

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CFindHeadSkinnedMeshRenderer_003Ed__10))]
		private IEnumerator FindHeadSkinnedMeshRenderer()
		{
			return null;
		}

		private Transform FindTransformByPartialName(string name, Transform trans)
		{
			return null;
		}
	}
}
