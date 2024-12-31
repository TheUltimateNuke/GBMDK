namespace CS.CorePlatform.Utils.Data.SystemMessages
{
	public class OculusGameInvite : PlatformMessageBase
	{
		private string _IP;

		private int _Port;

		private string _From;

		public string IP
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Port
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string From
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Serialize(DataWriter writer)
		{
		}

		protected override void Deserialize(DataReader reader)
		{
		}
	}
}
