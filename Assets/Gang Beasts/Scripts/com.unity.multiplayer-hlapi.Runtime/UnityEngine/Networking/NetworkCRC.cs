using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkCRC
	{
		internal static NetworkCRC s_Singleton;

		private Dictionary<string, int> m_Scripts;

		private bool m_ScriptCRCCheck;

		internal static NetworkCRC singleton => null;

		public Dictionary<string, int> scripts => null;

		public static bool scriptCRCCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void ReinitializeScriptCRCs(Assembly callingAssembly)
		{
		}

		public static void RegisterBehaviour(string name, int channel)
		{
		}

		internal static bool Validate(CRCMessageEntry[] scripts, int numChannels)
		{
			return false;
		}

		private bool ValidateInternal(CRCMessageEntry[] remoteScripts, int numChannels)
		{
			return false;
		}

		private void Dump(CRCMessageEntry[] remoteScripts)
		{
		}
	}
}
