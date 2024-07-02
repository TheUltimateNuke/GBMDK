using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DisplayCredits : MonoBehaviour
{
	public TextAsset textFile;

	private int _currentTextPoint;

	[SerializeField]
	public int _linesPerSection;

	public TextMeshProUGUI[] textFieldText;

	private Transform[] textTransforms;

	public float scrollSpeed;

	public Sprite[] forgrounds;

	public Image forground;

	public Image background;

	public Image fader;

	public bool fade;

	public float fadeTime;

	public float showTime;

	public int currentforground;

	public Color[] colours;

	public int currentColour;

	private float fadeTimer;

	private float showTimer;

	[SerializeField]
	private float _screenTop;

	[SerializeField]
	private UnityEvent OnCompelete;

	[SerializeField]
	private bool _debugMode;

	private bool fadeIn;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void FadeColours()
	{
	}

	private void UpdateText()
	{
	}

	private bool ApplyText(int i)
	{
		return false;
	}

	public void Reset()
	{
	}
}
