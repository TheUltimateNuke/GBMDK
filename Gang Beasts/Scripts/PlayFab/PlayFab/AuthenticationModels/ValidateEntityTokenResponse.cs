using System;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
	[Serializable]
	public class ValidateEntityTokenResponse : PlayFabResultCommon
	{
		public EntityKey Entity;

		public IdentifiedDeviceType? IdentifiedDeviceType;

		public LoginIdentityProvider? IdentityProvider;

		public string IdentityProviderIssuedId;

		public EntityLineage Lineage;
	}
}
