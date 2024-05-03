using UnityEngine;

namespace Costumes
{
	public static class CostumeDatabaseCache
	{
		private static CostumeDatabase _stored;

		public static CostumeDatabase DataBase => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}
	}
}
