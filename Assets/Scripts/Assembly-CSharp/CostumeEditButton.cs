using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CostumeEditButton : MonoBehaviour
{
	public string EditText;

	public string NewText;

	public SaveSelection SaveSelection;

	private TextMeshProUGUI _editText;

	private bool _isEditText;

	private Button button;

	public GameObject savesFullUI;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}
}
