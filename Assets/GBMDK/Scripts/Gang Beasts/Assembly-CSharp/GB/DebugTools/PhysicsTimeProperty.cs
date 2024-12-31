using Unity.Profiling;

namespace GB.DebugTools
{
	public class PhysicsTimeProperty
	{
		public const int PhysicsTimeBufferSize = 120;

		private long[] m_TimeBuffer;

		private ProfilerRecorder m_PhysicsStatRecorder;

		private DebugVariable<string> m_DebugVariable;

		public float LowWarningLimitMs;

		public float HighWarningLimitMs;

		public PhysicsTimeProperty(string debugVariableName, string profilerStatName, float lowWarningLimitMs = -1f, float highWarningLimitMs = -1f)
		{
		}

		public void Update(int currentBufferIndex)
		{
		}

		public void CreateDebugVariable(string name)
		{
		}

		public void InitProfilerRecorderer(string statName)
		{
		}

		public void UpdateStat(int currentBufferIndex)
		{
		}

		private long GetAverageTime()
		{
			return 0L;
		}

		public void UpdateDebugVariable(int currentBufferIndex)
		{
		}

		private void SetDebugVariableColor(float averageTimeMs)
		{
		}

		public static long GetRecorderFrameAverage(ProfilerRecorder recorder)
		{
			return 0L;
		}
	}
}
