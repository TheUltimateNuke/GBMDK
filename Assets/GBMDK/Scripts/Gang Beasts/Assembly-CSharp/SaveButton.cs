using System.Collections.Generic;
using Costumes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SaveButton : MonoBehaviour
{
	public Button ThisButton;

	public TextMeshProUGUI SaveButtonName;

	public MultiGraphicColor MultiGraphicColor;

	public RectTransform NumersList;

	public List<CostumeSaveNumber> SaveNumbers;

	public void BuildSaveEntryCode(string code)
	{
	}
}
