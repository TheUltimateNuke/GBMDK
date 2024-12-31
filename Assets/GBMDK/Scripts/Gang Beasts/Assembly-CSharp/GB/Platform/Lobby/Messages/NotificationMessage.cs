using CS.CorePlatform.Utils.Data;

namespace GB.Platform.Lobby.Messages
{
	public class NotificationMessage : LobbyMessage
	{
		private string _info;

		private bool _error;

		private float _timer;

		public string Info
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Error
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void DeserializeFromLobbyMessage(DataReader reader)
		{
		}

		protected override void Serialize(DataWriter writer)
		{
		}
	}
}
