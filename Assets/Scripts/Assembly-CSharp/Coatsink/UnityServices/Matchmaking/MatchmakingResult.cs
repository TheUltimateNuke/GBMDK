using GB.UnityServices.Matchmaking;

namespace Coatsink.UnityServices.Matchmaking
{
	public struct MatchmakingResult
	{
		public MatchmakingState State;

		public string Message;

		public string IpAddress;

		public int Port;

		public MatchmakingTicketModel originalTicket;

		public MatchmakingResult(MatchmakingState state, string message) : this()
        {
		}

		public bool IsSuccess()
		{
			return false;
		}
	}
}
