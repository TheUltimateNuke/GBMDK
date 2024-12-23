using UnityEngine;
using UnityEngine.Events;

namespace GB.Game
{
	[RequireComponent(typeof(Collider))]
	public class FootballGoal : MonoBehaviour
	{
		[SerializeField]
		public int GangID;

		[SerializeField]
		private UnityEvent AdditionalGoalEvents;

		private GoalResponse cachedResponse;

		private void OnTriggerEnter(Collider other)
		{
		}

		public void SetupGoalResponse(GoalResponse response)
		{
		}
	}
}
