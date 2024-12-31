using System;

[Serializable]
public class GameModeOption
{
	[Serializable]
	public class BoolOption
	{
		public bool Value;

		public bool UseOverride;

		public bool OverrideWhen;

		public string OverrideOptionName;

		public BoolOption(bool value, bool useOverride = false, bool overrideWhen = false, string overrideOptionName = null)
		{
		}

		public bool Override()
		{
			return false;
		}
	}

	[Serializable]
	public class IntOption
	{
		public int Value;

		public bool UseMinMax;

		public int MinValue;

		public int MaxValue;

		public IntOption(int value, bool useMinMax = false, int minValue = -1, int maxValue = -1)
		{
		}
	}

	[Serializable]
	public class FloatOption
	{
		public float Value;

		public bool UseMinMax;

		public float MinValue;

		public float MaxValue;

		public FloatOption(float value, bool useMinMax = false, float minValue = -1f, float maxValue = -1f)
		{
		}
	}

	[Serializable]
	public class StringChoiceOption
	{
		public int SelectedValueIndex;

		public string[] ValueArray;

		public StringChoiceOption(string[] valueArray, int selectedValueIndex = -1)
		{
		}

		public string MoveNext()
		{
			return null;
		}

		public string MovePrevious()
		{
			return null;
		}
	}

	[Serializable]
	public class LevelsOption
	{
		public bool _init;

		public int SelectedValueIndex;

		public LevelData[] ValueArray;

		public bool Init => false;

		public LevelsOption(LevelData[] valueArray, int selectedValueIndex = -1)
		{
		}

		public void GetLevels(string GameModeID, bool includeUnFinished = false)
		{
		}

		public LevelData MoveNextLevel()
		{
			return null;
		}

		public string MoveNextLevelName()
		{
			return null;
		}

		public LevelData MovePreviousLevel()
		{
			return null;
		}

		public LevelData Random()
		{
			return null;
		}

		public void RandomizeStartIndex()
		{
		}

		public int GetNumLevels()
		{
			return 0;
		}
	}

	public string OptionName;

	public readonly GameModeOptionType _gameModeOptionType;

	public BoolOption Bool;

	public IntOption Int;

	public FloatOption Float;

	public StringChoiceOption StringChoice;

	public LevelsOption Levels;

	public GameModeOptionType GameModeOptionType => default(GameModeOptionType);

	public GameModeOption(string optionName, bool value, bool useOverride = false, bool overrideWhen = false, string overrideOptionName = null)
	{
	}

	public GameModeOption(string optionName, int value, bool useMinMax = false, int minValue = -1, int maxValue = -1)
	{
	}

	public GameModeOption(string optionName, float value, bool useMinMax = false, float minValue = -1f, float maxValue = -1f)
	{
	}

	public GameModeOption(string optionName, string[] valueArray, int selectedValueIndex = -1)
	{
	}

	public GameModeOption(string optionName, LevelData[] valueArray, int selectedValueIndex = -1)
	{
	}
}
