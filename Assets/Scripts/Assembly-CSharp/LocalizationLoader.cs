using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Data.Loading;
using GB.Setup;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

public class LocalizationLoader : MonoBehaviour, IAsyncResourceLoader
{
	[CompilerGenerated]
	private sealed class _003CDownloadLocalizations_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetsDownloader downloader;

		public int startLoad;

		public int endLoad;

		public LocalizationLoader _003C_003E4__this;

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
		public _003CDownloadLocalizations_003Ed__5(int _003C_003E1__state)
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
	private sealed class _003CPreloadDefaultTable_003Ed__6<TTable, TEntry> : IEnumerator<object>, IEnumerator, IDisposable where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocalizedDatabase<TTable, TEntry> database;

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
		public _003CPreloadDefaultTable_003Ed__6(int _003C_003E1__state)
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

	private const string LOCALE_LABEL = "Locale";

	private const string STRING_TABLE_SHARED_DATA_ADDRESS = "Assets/StringTable Shared Data.asset";

	public void Awake()
	{
	}

	public IList<object> GetAssetKeys()
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadLocalizations_003Ed__5))]
	public IEnumerator DownloadLocalizations(AssetsDownloader downloader, int startLoad, int endLoad)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPreloadDefaultTable_003Ed__6<, >))]
	private IEnumerator PreloadDefaultTable<TTable, TEntry>(LocalizedDatabase<TTable, TEntry> database) where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		return null;
	}

	public void BeginAsyncLoading()
	{
	}

	public bool HasFinishedAsyncLoading()
	{
		return false;
	}

	public bool HasErrors()
	{
		return false;
	}
}
