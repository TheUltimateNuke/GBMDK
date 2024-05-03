using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class CostumeBundle
	{
		public string BundleName;

		public List<CostumeBundleAsset> BundleAssets;

		[NonSerialized]
		public AssetBundle AssetBundle;
	}
}
