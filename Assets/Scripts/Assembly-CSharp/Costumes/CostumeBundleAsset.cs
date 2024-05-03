using System;

namespace Costumes
{
	[Serializable]
	public struct CostumeBundleAsset
	{
		public ushort CostumeObjectID;

		public ushort CostumeItemID;

		public string AssetName;

		public string AssetPath;
	}
}
