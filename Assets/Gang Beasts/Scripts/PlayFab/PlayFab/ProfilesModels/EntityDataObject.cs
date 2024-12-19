using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityDataObject : PlayFabBaseModel
	{
		public object DataObject;

		public string EscapedDataObject;

		public string ObjectName;
	}
}
