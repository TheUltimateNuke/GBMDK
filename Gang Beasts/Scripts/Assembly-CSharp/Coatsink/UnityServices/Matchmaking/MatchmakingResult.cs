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

		public MatchmakingResult(MatchmakingState state, string message)
		{
			State = default(MatchmakingState);
			Message = null;
			IpAddress = null;
			Port = 0;
			originalTicket = null;
		}

		public bool IsSuccess()
		{
			return false;
		}
	}
}
