using System;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;

namespace GB.Data.Localisation
{
	[Serializable]
	[DisplayName("Language Key", null)]
	[Metadata(AllowedTypes = MetadataType.StringTable)]
	public class LanguageKey : IMetadata
	{
		public string name;
	}
}
