using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Platform.Utils
{
	public class AutoSaveLogo : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitToCloseLocalSaving_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoSaveLogo _003C_003E4__this;

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
			public _003CWaitToCloseLocalSaving_003Ed__17(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CWaitToCloseLocalLoading_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoSaveLogo _003C_003E4__this;

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
			public _003CWaitToCloseLocalLoading_003Ed__20(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CWaitToCloseCloudSaving_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoSaveLogo _003C_003E4__this;

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
			public _003CWaitToCloseCloudSaving_003Ed__23(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CWaitToCloseCloudLoading_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AutoSaveLogo _003C_003E4__this;

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
			public _003CWaitToCloseCloudLoading_003Ed__26(int _003C_003E1__state)
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
		private GameObject _SaveLocalObject;

		[SerializeField]
		private Transform _SaveLocalObjectTransform;

		[SerializeField]
		private GameObject _LoadLocalObject;

		[SerializeField]
		private Transform _LoadLocalObjectTransform;

		[SerializeField]
		private GameObject _SaveCloudObject;

		[SerializeField]
		private Transform _SaveCloudObjectTransform;

		[SerializeField]
		private GameObject _LoadCloudObject;

		[SerializeField]
		private Transform _LoadCloudObjectTransform;

		private bool _localSaving;

		private bool _localLoading;

		private bool _CloudSaving;

		private bool _CloudLoading;

		private void Awake()
		{
		}

		private void OnSaveLoadFailEvent(bool save)
		{
		}

		private void OnDestroy()
		{
		}

		private void StartSaveLocal()
		{
		}

		private void StopSaveLocal()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToCloseLocalSaving_003Ed__17))]
		private IEnumerator WaitToCloseLocalSaving()
		{
			return null;
		}

		private void StartLoadLocal()
		{
		}

		private void StopLoadLocal()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToCloseLocalLoading_003Ed__20))]
		private IEnumerator WaitToCloseLocalLoading()
		{
			return null;
		}

		private void StartSaveCloud()
		{
		}

		private void StopSaveCloud()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToCloseCloudSaving_003Ed__23))]
		private IEnumerator WaitToCloseCloudSaving()
		{
			return null;
		}

		private void StartLoadCloud()
		{
		}

		private void StopLoadCloud()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitToCloseCloudLoading_003Ed__26))]
		private IEnumerator WaitToCloseCloudLoading()
		{
			return null;
		}
	}
}
