using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
	public abstract class BaseImageLoading : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitForFullyLoaded_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WWW imageLoading;

			public Texture2D storepoint;

			public BaseImageLoading _003C_003E4__this;

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
			public _003CWaitForFullyLoaded_003Ed__6(int _003C_003E1__state)
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

		protected Dictionary<BaseUserInfo, Texture2D> _StoredPictures;

		protected Dictionary<BaseUserInfo, Texture2D> _WaitingLoadedPictures;

		protected Dictionary<Texture2D, BaseUserInfo> _LoadingImages;

		public bool TryLoadingFromStored(BaseUserInfo id, ref Texture2D textureStore)
		{
			return false;
		}

		public void UnloadPlayingWithImage(BaseUserInfo id)
		{
		}

		public void StartLoadingImage(ref Texture2D textureStore, string imageURL)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForFullyLoaded_003Ed__6))]
		protected IEnumerator WaitForFullyLoaded(WWW imageLoading, Texture2D storepoint)
		{
			return null;
		}
	}
}
