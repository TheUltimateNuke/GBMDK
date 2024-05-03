namespace CoreNet.Messaging.Permissions
{
	public class Guestlist : Permission
	{
		public override bool IsPermitted(int connectionId)
		{
			return false;
		}
	}
}
