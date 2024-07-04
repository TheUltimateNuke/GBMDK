using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablesDiagnostics
{
	private class Manager
	{
		private static Manager _instance;

		private static readonly object _instanceLock;

		private static readonly string[] _reportsHeaders;

		private List<Session> _sessions;

		private Session _activeSession;

		private Manager()
		{
		}

		public static void Init()
		{
		}

		public static void StartSession(string sessionName, bool shouldLogEmptySession)
		{
		}

		public static void StopSession()
		{
		}

		public static void Quit()
		{
		}

		private static void InitInternal()
		{
		}

		private static void DiagnosticCallback(ResourceManager.DiagnosticEventContext context)
		{
		}

		private void StartSessionInternal(string sessionName = null, bool shouldLogEmptySession = false)
		{
		}

		private void StopSessionInternal()
		{
		}

		private void DiagnosticCallbackInternal(ResourceManager.DiagnosticEventContext context)
		{
		}

		private void QuitInternal()
		{
		}

		private void PrintGrandTotal()
		{
		}

		private void InitReport()
		{
		}
	}

	private class Session
	{
		private struct OperationData
		{
			public float StartTime;
		}

		public float TotalWallTime;

		public long TotalBytesDownloaded;

		private string _sessionName;

		private float _loadingStartTime;

		private Dictionary<int, OperationData> _operations;

		public string SessionName => null;

		public bool ShouldLogEmptySession { get; }

		public Session(string sessionName = null, bool shouldLogEmptySession = false)
		{
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void PrintSummary()
		{
		}

		public void OnAsyncOperationCreate(ResourceManager.DiagnosticEventContext context)
		{
		}

		public void OnAsyncOperationComplete(ResourceManager.DiagnosticEventContext context)
		{
		}

		private void CalculateTimeStats(int key, out float selfTime)
		{
			selfTime = default(float);
		}

		private void CalculateSizeStats(DownloadStatus downloadStatus, out long bytesDownloaded)
		{
			bytesDownloaded = default(long);
		}

		private static string BytesToString(long byteCount)
		{
			return null;
		}

		private void WriteToReport(string assetBundleName, string status, string sessionName, string time, string downloadedSize)
		{
		}
	}

	public const string LOG_PREFIX = "[AddressablesDiagnostics]";

	public static bool VerboseLogging;

	public static bool ReportLogging;

	private static bool _enabled;

	public static bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static string ReportsDirectory => null;

	private static string ReportFilePath => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void RuntimeInitializeOnLoad()
	{
	}

	public static void StartSession(string sessionName, bool shouldLogEmptySession = true)
	{
	}

	public static void StopSession()
	{
	}
}
