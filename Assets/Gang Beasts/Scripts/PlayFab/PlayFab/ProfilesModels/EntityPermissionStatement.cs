using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityPermissionStatement : PlayFabBaseModel
	{
		public string Action;

		public string Comment;

		public object Condition;

		public EffectType Effect;

		public object Principal;

		public string Resource;
	}
}
