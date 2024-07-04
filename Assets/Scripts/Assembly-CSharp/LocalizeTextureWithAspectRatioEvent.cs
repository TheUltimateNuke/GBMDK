using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class LocalizeTextureWithAspectRatioEvent : LocalizeTextureEvent
{
	[SerializeField]
	private AspectRatioFitter _fitter;

	public void SetAssetEntryKey(string key)
	{
	}

	private void Awake()
	{
	}

	protected override void UpdateAsset(Texture texure)
	{
	}
}
