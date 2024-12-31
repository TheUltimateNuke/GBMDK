using System.Collections.Generic;

namespace Costumes
{
	public class CostumeSaveDatabase
	{
		public static readonly int MAX_SAVES;

		public static readonly int MAX_CLOUD_SAVES;

		public List<string> RecycledCloudIDs;

		public List<CostumeSaveEntry> CostumeSaveList;
	}
}
