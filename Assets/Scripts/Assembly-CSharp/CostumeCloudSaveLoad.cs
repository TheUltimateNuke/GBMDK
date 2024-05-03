using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using GB.Networking.Objects;
using UnityEngine;

public static class CostumeCloudSaveLoad
{
	public class CostumeCloudData
	{
		public string id { get; set; }

		public string code { get; set; }

		public string data { get; set; }

		public string timestamp { get; set; }

		public CostumeCloudData(CostumeSaveEntryStruct.CostumeCloudDataStruct cloudDataStruct)
		{
		}

		public CostumeCloudData(NetCostumeCloudData data)
		{
		}

		public CostumeCloudData(CostumeCloudData cloudDataStruct)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CSaveCostumeRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string costumeData;

		public Action<CostumeCloudData> saveCostumeCallback;

		private string _003Curl_003E5__2;

		private WWWForm _003Cform_003E5__3;

		private WWW _003Cwww_003E5__4;

		private int _003Cretry_003E5__5;

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
		public _003CSaveCostumeRoutine_003Ed__6(int _003C_003E1__state)
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
	private sealed class _003CUpdateCostumeRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string costumeId;

		public string costumeData;

		public Action<CostumeCloudData> updateCostumeCallback;

		private string _003Curl_003E5__2;

		private WWWForm _003Cform_003E5__3;

		private WWW _003Cwww_003E5__4;

		private int _003Cretry_003E5__5;

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
		public _003CUpdateCostumeRoutine_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003CGetCostumeRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string costumeCode;

		public Action<CostumeCloudData> getCostumeCallback;

		private string _003Curl_003E5__2;

		private WWW _003Cwww_003E5__3;

		private int _003Cretry_003E5__4;

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
		public _003CGetCostumeRoutine_003Ed__10(int _003C_003E1__state)
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

	private const string BASE_URL = "http://gbcostumedb-dev.elasticbeanstalk.com/";

	private const string SAVE_COSTUME_ENDPOINT = "new_costume_post";

	private const string UPDATE_COSTUME_ENDPOINT = "update_costume_post/{0}";

	private const string GET_COSTUME_ENDPOINT = "get_costume/bycode/{0}";

	public static void SaveCostume(MonoBehaviour coroutineRunner, string costumeData, Action<CostumeCloudData> saveCostumeCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CSaveCostumeRoutine_003Ed__6))]
	private static IEnumerator SaveCostumeRoutine(string costumeData, Action<CostumeCloudData> saveCostumeCallback)
	{
		return null;
	}

	public static void UpdateCostume(MonoBehaviour coroutineRunner, string costumeId, string costumeData, Action<CostumeCloudData> updateCostumeCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCostumeRoutine_003Ed__8))]
	private static IEnumerator UpdateCostumeRoutine(string costumeId, string costumeData, Action<CostumeCloudData> updateCostumeCallback)
	{
		return null;
	}

	public static void GetCostume(MonoBehaviour coroutineRunner, string costumeCode, Action<CostumeCloudData> getCostumeCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CGetCostumeRoutine_003Ed__10))]
	private static IEnumerator GetCostumeRoutine(string costumeCode, Action<CostumeCloudData> getCostumeCallback)
	{
		return null;
	}

	private static byte[] GetBytes(string str)
	{
		return null;
	}

	private static string GetString(byte[] bytes)
	{
		return null;
	}
}
