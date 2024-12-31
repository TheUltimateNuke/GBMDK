namespace CoreNet.Messaging.Permissions
{
	public class Blacklist : Permission
	{
		public override bool IsPermitted(int connectionId)
		{
			return false;
		}
	}
}
