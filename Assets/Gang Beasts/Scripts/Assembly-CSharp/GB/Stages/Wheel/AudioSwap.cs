using UnityEngine;
using UnityEngine.Audio;

namespace GB.Stages.Wheel
{
	public class AudioSwap : MonoBehaviour
	{
		[SerializeField]
		private AudioSource _source;

		[SerializeField]
		private AudioMixerGroup _controller;

		[SerializeField]
		private bool _playASide;

		private void Start()
		{
		}
	}
}
