using TMPro;
using UnityEngine;

public class PunchBag : MonoBehaviour
{
	public enum DamageState
	{
		normal = 0,
		special = 1,
		falling = 2
	}

	public float damageMinimumVelocity;

	public float damageModifier;

	public float damageSpamCounter;

	public DamageState damageState;

	public float knockoutThreshold;

	public float painThreshold;

	public float health;

	public float maxHealth;

	public float healthRegeneration;

	public float healthDamage;

	public bool unconscious;

	public float unconsciousTime;

	public float maxUnconsciousTime;

	public TextMeshProUGUI healthText;

	public TextMeshProUGUI damageText1;

	public TextMeshProUGUI damageText2;

	public TextMeshProUGUI damageText3;

	public TextMeshProUGUI damageText4;

	public TextMeshProUGUI damageText5;

	public TextMeshProUGUI averageText;

	public TextMeshProUGUI damagePerSecondText;

	public TextMeshProUGUI hitsPerSecondText;

	public LineRenderer line;

	private float dmg1;

	private float dmg2;

	private float dmg3;

	private float dmg4;

	private float dmg5;

	public bool scrollLine;

	private bool ticked;

	public float damagePerSecond;

	public float hitsPerSecond;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void DPS()
	{
	}

	private void Update()
	{
	}

	private void DamageCheck(InteractableObject collisionInteractable, Transform collisionTransform, Rigidbody collisionRigidbody, Collider collisionCollider, Collision collision, Vector3 relativeVelocity, float velocityMagnitude)
	{
	}

	public void UpdateHealth()
	{
	}

	public void CheckConscious()
	{
	}

	public void UpdateDamage(float damage)
	{
	}

	private void Tick()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
