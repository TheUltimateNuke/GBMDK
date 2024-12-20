namespace CoreNet.Messaging.Permissions
{
	public class Whitelist : Permission
	{
		public override bool IsPermitted(int connectionId)
		{
			return false;
		}
	}
}
