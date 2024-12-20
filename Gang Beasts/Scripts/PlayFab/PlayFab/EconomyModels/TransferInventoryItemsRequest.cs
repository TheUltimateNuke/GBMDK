using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
	[Serializable]
	public class TransferInventoryItemsRequest : PlayFabRequestCommon
	{
		public int? Amount;

		public Dictionary<string, string> CustomTags;

		public bool DeleteEmptyStacks;

		public string GivingCollectionId;

		public EntityKey GivingEntity;

		public string GivingETag;

		public InventoryItemReference GivingItem;

		public string IdempotencyId;

		public InitialValues NewStackValues;

		public string ReceivingCollectionId;

		public EntityKey ReceivingEntity;

		public InventoryItemReference ReceivingItem;
	}
}
