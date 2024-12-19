using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
	[Serializable]
	public class SetObject : PlayFabBaseModel
	{
		public object DataObject;

		public bool? DeleteObject;

		public string EscapedDataObject;

		public string ObjectName;
	}
}
