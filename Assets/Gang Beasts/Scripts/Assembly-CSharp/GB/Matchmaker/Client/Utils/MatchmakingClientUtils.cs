using System.Collections.Generic;
using Coatsink.UnityServices.Matchmaking;
using GB.UnityServices.Matchmaking;
using Unity.Services.Matchmaker;

namespace GB.Matchmaker.Client.Utils
{
	public static class MatchmakingClientUtils
	{
		private const string logPrefix = "[MatchmakingClientUtils]";

		public static bool SetTicketRequestProperties(ref List<MMPlayer> players, ref CreateTicketOptions ticketOptions, MatchmakingTicketModel ticketModel, out string error)
		{
			error = null;
			return false;
		}

		private static bool SetTicketData(Dictionary<string, object> attributes, string key, object value, bool ConvertObjToJson = false)
		{
			return false;
		}
	}
}
