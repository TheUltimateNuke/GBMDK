using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	public static class IDominantExtensions
	{
		[CompilerGenerated]
		private sealed class _003CLoadSubmissiveOffsetsNextFrame_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IDominant dominant;

			public Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets;

			public Transform transform;

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
			public _003CLoadSubmissiveOffsetsNextFrame_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CLoadSubmissiveOffsetsNextFrame_003Ed__0))]
		public static IEnumerator LoadSubmissiveOffsetsNextFrame(this IDominant dominant, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
			return null;
		}

		public static void LoadSubmissiveOffsets(this IDominant dominant, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
		}

		public static Demand CreateDemand(this IDominant dominant, SubmissiveRigidbody sub, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
			return null;
		}
	}
}
