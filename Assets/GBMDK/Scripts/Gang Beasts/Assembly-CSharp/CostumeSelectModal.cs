using Costumes;
using Femur;
using GB.Core.UI;
using GB.Input;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.InputSystem.Users;
using UnityEngine.UI;

public class CostumeSelectModal : MonoBehaviour
{
	private enum SelectStatus
	{
		Unselected = 0,
		Selecting = 1,
		Selected = 2
	}

	[SerializeField]
	private Transform _spawnPoint;

	[SerializeField]
	private GameObject EnableOnActive;

	[SerializeField]
	private Text CostumeNamePanel;

	[SerializeField]
	private Text ColourNamePanel;

	private Actor _actorCache;

	private ActorCostume _costumeCache;

	private CostumeSaveEntry _costumeSaveEntry;

	private NetBeast _netBeastRef;

	private CostumeMultiModalHandler _parentRef;

	private InputUser _cachedPlayer;

	private int _lastColourIndex;

	[SerializeField]
	private SelectStatus _selectionStatus;

	private int _currentCostumeIndex;

	private int _currentColourIndex;

	private int _controllerIDToListenFor;

	private int _lastHoriInput;

	private string _cachedPref;

	private RemappingMenuManager RemappingManagerRef;

	private Coroutine _coroutineSetCostume;

	public void Initialise(int controlID = 0, CostumeMultiModalHandler parentHandler = null)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void SetColour()
	{
	}

	private void SetCostume()
	{
	}

	public void NextCostume()
	{
	}

	public void PreviousCostume()
	{
	}

	public void NextColour()
	{
	}

	public void PreviousColour()
	{
	}
}
