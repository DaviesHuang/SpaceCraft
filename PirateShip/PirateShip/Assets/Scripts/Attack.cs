using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health> ();
		if (health != null) {
			health.TakeDamage (10);
		}

		Destroy (gameObject);
	}
}
