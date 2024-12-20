using System.Collections.Generic;

namespace GB.UnityServices.Matchmaking
{
	public class MatchmakingTicketModel
	{
		public MatchmakingFilters matchmakingFilters { get; set; }

		public List<MatchmakingPlayerModel> Players { get; set; }
	}
}
