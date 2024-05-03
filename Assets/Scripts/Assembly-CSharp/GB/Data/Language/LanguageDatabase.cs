using System;
using System.Collections.Generic;
using UnityEngine;

namespace GB.Data.Language
{
	public class LanguageDatabase : ScriptableObject
	{
		public enum PS4SystemLanguage
		{
			JAPANESE = 0,
			ENGLISH_US = 1,
			FRENCH = 2,
			SPANISH = 3,
			GERMAN = 4,
			ITALIAN = 5,
			DUTCH = 6,
			PORTUGUESE_PT = 7,
			RUSSIAN = 8,
			KOREAN = 9,
			CHINESE_T = 10,
			CHINESE_S = 11,
			FINNISH = 12,
			SWEDISH = 13,
			DANISH = 14,
			NORWEGIAN = 15,
			POLISH = 16,
			PORTUGUESE_BR = 17,
			ENGLISH_GB = 18,
			TURKISH = 19,
			SPANISH_LA = 20,
			ARABIC = 21,
			FRENCH_CA = 22
		}

		[Serializable]
		public class Language
		{
			[SerializeField]
			public string key;

			[SerializeField]
			public SystemLanguage[] useIfSystemLanguageEquals;

			[SerializeField]
			public PS4SystemLanguage[] ps4For;

			public Language(string newKey)
			{
			}

			public bool IsFor(SystemLanguage check)
			{
				return false;
			}

			public bool IsFor(PS4SystemLanguage check)
			{
				return false;
			}
		}

		[SerializeField]
		public List<Language> languages;
	}
}
