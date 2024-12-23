using PartyCSharpSDK;
using PlayFab.ClientModels;

namespace PlayFab.Party
{
	public class PlayFabPlayer
	{
		private ChatState _chatState;

		private float _voiceLevel;

		private bool _isMuted;

		internal string _entityToken;

		internal bool _isLocal;

		internal string _platformSpecificUserId;

		internal PARTY_ENDPOINT_HANDLE _endPointHandle;

		internal PARTY_CHAT_CONTROL_HANDLE _chatControlHandle;

		internal bool _mutedByPlatform;

		private const string _ErrorMessageVoiceLevelOutOfRange = "Value {0} is out of range. Value must be between 0 and 1.";

		public ChatState ChatState => default(ChatState);

		public EntityKey EntityKey { get; private set; }

		public bool IsLocal => false;

		public bool IsMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float VoiceLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal void _SetEntityKey(EntityKey entityKey)
		{
		}
	}
}
