using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CostumeDeleteButton : MonoBehaviour
{
	public SaveSelection SaveSelection;

	public Button selectWhenInactive;

	private Button _deleteButton;

	private TextMeshProUGUI _text;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
