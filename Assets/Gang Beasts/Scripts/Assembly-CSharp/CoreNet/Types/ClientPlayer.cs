using System;
using Femur;
using UnityEngine;

namespace CoreNet.Types
{
	[Serializable]
	public class ClientPlayer
	{
		public Actor ActorTemplate;

		public int PlayerID;

		public int GangID;

		public short ControllerID;

		public Actor LivingBeastRef;

		public Color PrimaryColor;

		public Color CostumeColor;

		public ClientPlayer(int playerID, short controlID)
		{
		}
	}
}
