using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

public class LanguageSwitcher : MonoBehaviour
{
	[SerializeField]
	private LocalizedStringTable table;

	[SerializeField]
	private TMP_Text entryPrefab;

	private bool displayAllStrings;

	public void SetValue()
	{
	}

	public void PopulateTableWithErrorStrins(List<string> list)
	{
	}

	public void PopulateTable()
	{
	}

	public void ChangeDisplayedStrings()
	{
	}
}
