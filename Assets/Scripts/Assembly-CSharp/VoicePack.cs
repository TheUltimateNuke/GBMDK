using UnityEngine;

public class VoicePack : ScriptableObject
{
	public AudioClip[] budBud;

	public AudioClip[] deathDefault;

	public AudioClip[] deathFalling;

	public AudioClip[] exert;

	public AudioClip[] knockout;

	public AudioClip[] laugh;

	public AudioClip[] meh;

	public AudioClip[] mungy;

	public AudioClip[] nieNie;

	public AudioClip[] uu;

	public AudioClip[] victory;

	public AudioClip[] vert;

	public AudioClip[] da;

	public AudioClip[] dee;

	public AudioClip[] doh;

	[Header("Chances to play each frame /10000")]
	[Tooltip("Mungy")]
	public float grabbing;

	[Tooltip("Meh")]
	public float idle;

	[Tooltip("Doh")]
	public float healthy;

	[Tooltip("Laugh")]
	public float lowHealth;
}
