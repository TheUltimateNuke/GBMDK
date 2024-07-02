using System.Collections.Generic;
using CS.CorePlatform;
using Coatsink.Platform.Systems.User;
using GB.Platform.Lobby.Messages;

namespace GB.Platform.Lobby
{
	public class LobbyColourLocker : LobbyPart
	{
		public class ColourLock
		{
			private BaseUserInfo _user;

			private int _controllerID;

			public BaseUserInfo User => default(BaseUserInfo);

			public int Controller => 0;

			public bool Locked => false;

			public void Lock(BaseUserInfo user, int controller)
			{
			}

			public void Unlock()
			{
			}

			public bool LockedTo(BaseUserInfo user, int controller)
			{
				return false;
			}

			public bool Copy(ColourLock target)
			{
				return false;
			}
		}

		private BasePlatformManager _managerCache;

		private List<ColourLock> _colourLocks;

		private int _totalFreeColours;

		private ColourChangeRequestMsg _messageRequest;

		private ColourChangeRequestMsg _messageAssign;

		private ColourUpdateMessage _messageUpdate;

		private bool _drawInspectorToggleVal;

		private void Awake()
		{
		}

		public override void ClearData()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void CreateColourLocks()
		{
		}

		private void OnMeJoinSendColorRequest(int controller)
		{
		}

		private void ClearUserLock(BaseUserInfo info)
		{
		}

		private void ClearLocks()
		{
		}

		private void ColourChanged(BaseUserInfo arg1, ColourChangeRequestMsg arg2)
		{
		}

		private void RecievedColourRequest(BaseUserInfo arg1, ColourChangeRequestMsg arg2)
		{
		}

		public int ManualAssignColour(BaseUserInfo user, int controller, int colour)
		{
			return 0;
		}

		private void OnAllawanceChange(BaseUserInfo user, int arg2, bool arg3, OnlineID id)
		{
		}

		private void ColourUpdate(BaseUserInfo arg1, ColourUpdateMessage arg2)
		{
		}

		private void SendAllLocks(BaseUserInfo arg1, int arg2)
		{
		}

		public int GetCurrentColour(BaseUserInfo user, int controllerID)
		{
			return 0;
		}

		public int GetRandomColour(bool freeonly, int fallback)
		{
			return 0;
		}

		public int GetNextColour(int start, int change)
		{
			return 0;
		}

		public bool RequestColour(int controller, int colourID)
		{
			return false;
		}

		public void RequestNextColour(int controller, int change)
		{
		}

		public void RequestFree(int controller)
		{
		}

		private void ForceColourChanged(int controllerID, ColourChangeRequestMsg.ColourChange change, int colourIndex)
		{
		}

		public void ForceColourRequest(int controllerID, ColourChangeRequestMsg.ColourChange change, int param1)
		{
		}

		public override void DrawInspector()
		{
		}
	}
}
