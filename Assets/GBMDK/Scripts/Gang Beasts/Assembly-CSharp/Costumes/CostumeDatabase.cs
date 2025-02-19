using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Costumes
{
	public class CostumeDatabase
	{
		[CompilerGenerated]
		private sealed class _003CLoad_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumeDatabase _003C_003E4__this;

			private AsyncOperationHandle<IList<CostumeObject>> _003Cop_003E5__2;

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
			public _003CLoad_003Ed__12(int _003C_003E1__state)
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

		public const string COSTUMES_LABEL = "Costume";

		public const string COSTUME_ITEMS_LABEL = "CostumeItem";

		private List<CostumeObject> CostumeObjects;

		private SortedList<uint, CostumeObject> searchSpeeder;

		private static CostumeDatabase _instance;

		private static readonly object _lock;

		public bool IsLoaded { get; private set; }

		public static CostumeDatabase Instance => null;

		[IteratorStateMachine(typeof(_003CLoad_003Ed__12))]
		public IEnumerator Load()
		{
			return null;
		}

		public CostumeObject GetCostumeObjectWithID(ushort id, bool isEnabled = false, bool isUnlocked = false)
		{
			return null;
		}

		public List<CostumeObject> GetAllCostumeObjects(bool isEnabled = true, bool isUnlocked = true)
		{
			return null;
		}

		private List<CostumeObject> GetEnabled(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private List<CostumeObject> GetUnlocked(List<CostumeObject> costumeObjectList)
		{
			return null;
		}

		private bool IsUnlocked(CostumeObject costumeObject)
		{
			return false;
		}

		private void ParseCostumeOperationResult(IList<CostumeObject> result)
		{
		}
	}
}
