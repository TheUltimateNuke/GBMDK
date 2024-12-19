using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.UI.Utils;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	public class AssetsDownloader : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public bool needToReload;

			internal void _003CDownload_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDownload_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetsDownloader _003C_003E4__this;

			public int endStep;

			public int startStep;

			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			private int _003CtotalStep_003E5__2;

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
			public _003CDownload_003Ed__16(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStartDownload_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetsDownloader _003C_003E4__this;

			public int startStep;

			public int totalStep;

			private AsyncOperationHandle _003CdownloadHandle_003E5__2;

			private float _003Cprogress_003E5__3;

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
			public _003CStartDownload_003Ed__17(int _003C_003E1__state)
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

		public readonly IList Assets;

		public LoadingBar LoadingBar { get; set; }

		private bool IsDownloading { get; set; }

		private AsyncOperationStatus DownloadingStatus { get; set; }

		private bool IsDownloadSuccessfully => false;

		public void Reset()
		{
		}

		[IteratorStateMachine(typeof(_003CDownload_003Ed__16))]
		public IEnumerator Download(int startStep, int endStep)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStartDownload_003Ed__17))]
		private IEnumerator StartDownload(int startStep, int totalStep)
		{
			return null;
		}
	}
}
