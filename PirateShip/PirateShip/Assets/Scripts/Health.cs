using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;


public class Health : NetworkBehaviour {

	public const int maxHealth = 100;
	[SyncVar]
	public int currentHealth = maxHealth;
	public RectTransform healthBar;



	public void TakeDamage(int amount) {
		if (!isServer) {
			return;
		}
		currentHealth -= amount;
		if (currentHealth <= 0) {
			currentHealth = 0;
			Debug.Log ("Dead");
		}

		OnChangeHealth ();
	}

	void OnChangeHealth ()
	{
		healthBar.sizeDelta = new Vector2 (currentHealth, healthBar.sizeDelta.y);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
