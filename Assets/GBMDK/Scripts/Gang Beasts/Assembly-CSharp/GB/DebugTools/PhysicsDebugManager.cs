using System.Collections.Generic;

namespace GB.DebugTools
{
	public class PhysicsDebugManager
	{
		private List<PhysicsTimeProperty> m_PhysicsTimeProperty;

		private int m_CurrentBufferIndex;

		public void Update()
		{
		}

		public void AddStat(string debugVariableName, string profilerStatName, float lowWarningLimitMs = -1f, float highWarningLimitMs = -1f)
		{
		}
	}
}
