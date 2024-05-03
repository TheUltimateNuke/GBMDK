using UnityEngine;
using UnityEngine.UI;

public class ImageReplacer : MonoBehaviour
{
	[SerializeField]
	private string _currentCode;

	[SerializeField]
	private RawImage _target;

	[SerializeField]
	private AspectRatioFitter _fitter;

	public string Code
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RawImage Target
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

	public void SetToCode(string code)
	{
	}

	private void UpdateTarget()
	{
	}
}
