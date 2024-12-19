using System.Collections.Generic;
using GB.UnityServices.Matchmaking;

namespace GB.Networking
{
	public class GBSessionData
	{
		public HashSet<string> MatchmakerPlayerIds;

		public MatchmakingTicketModel MatchmakerTicket;
	}
}
