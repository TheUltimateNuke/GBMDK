namespace Coatsink.UnityServices.Matchmaking
{
	public enum MatchmakingState
	{
		None = 0,
		RequestError = 1,
		Started = 2,
		QosFailed = 3,
		NoPlayersInTicket = 4,
		AlreadyRunning = 5,
		TicketCreationError = 6,
		TicketCancellationError = 7,
		TicketRetrievalError = 8,
		MatchAssignmentError = 9,
		Success = 10
	}
}
