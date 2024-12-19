namespace Coatsink.UnityServices.Authentication
{
	public enum AuthState
	{
		NotAuthenticated = 0,
		Authenticating = 1,
		Authenticated = 2,
		Error = 3,
		TimedOut = 4
	}
}
