using System;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace CcdConfiguration
{
	[Serializable]
	public class CcdConfigInitialization : IInitializableObject
	{
		private class CcdConfigInitializeOperation : AsyncOperationBase<bool>
		{
			public string SerializedData;

			private bool _hasExecuted;

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Execute()
			{
			}
		}

		public bool Initialize(string id, string serializedData)
		{
			return false;
		}

		public AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string serializedData)
		{
			return default(AsyncOperationHandle<bool>);
		}

		public static bool DoInitialization(string serializedData)
		{
			return false;
		}

		private static void ProcessSerializedData(string serializedData)
		{
		}

		private static void ProcessCommandlineArgs()
		{
		}

		private static void AddWebRequestOverride(string authToken)
		{
		}
	}
}
