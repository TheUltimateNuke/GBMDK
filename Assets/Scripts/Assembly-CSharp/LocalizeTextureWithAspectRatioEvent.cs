using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

public class LocalizeTextureWithAspectRatioEvent : LocalizeTextureEvent
{
	[SerializeField]
	private AspectRatioFitter _fitter;

	private TableReference defaultAssetTableReference;

	public void SetAssetEntryKey(string key)
	{
	}

	private void Awake()
	{
	}

	protected override void UpdateAsset(Texture texure)
	{
	}

	public bool TableContainsEntryForKey(string key)
	{
		return false;
	}
}
