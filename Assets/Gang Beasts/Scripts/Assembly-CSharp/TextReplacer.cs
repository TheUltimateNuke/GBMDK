using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class TextReplacer : MonoBehaviour
{
	private List<string> Codes;

	private string _currentCode;

	[SerializeField]
	private TextMeshProUGUI _target;

	[SerializeField]
	private Text _targetText;

	[SerializeField]
	private LocalizeStringEvent _event;

	[SerializeField]
	private LocalizedString currentStringRef;

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TextMeshProUGUI Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Text TargetText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void SetPureCode(string code)
	{
	}

	public void SetToCode(string code)
	{
	}

	private void UpdateTarget(Locale locale = null)
	{
	}
}
