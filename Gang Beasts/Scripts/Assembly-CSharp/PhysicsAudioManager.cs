using System.Collections.Generic;
using UnityEngine;

public class PhysicsAudioManager : MonoBehaviour
{
	private List<PhysicAudioEmitter> m_PhysicsAudioEmitters;

	private static PhysicsAudioManager m_Instance;

	public static PhysicsAudioManager Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}

	public void AddPhysicsAudioEmitter(PhysicAudioEmitter physicsAudioEmitter)
	{
	}

	public void RemovePhysicsAudioEmitter(PhysicAudioEmitter physicsAudioEmitter)
	{
	}
}
