using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ShipController : NetworkBehaviour {

    public float AccelerateForce = 4f;
    public float DecelerateForce = -1f;
    public float torqueForce = 3f;

    public float xMin = -14f;
    public float xMax = 14f;
    public float yMin = -14f;
    public float yMax = 14f;

    public GameObject shot;
    public Transform shotSpawn1;
    public Transform shotSpawn2;
    public Transform shotSpawn3;
    public Transform shotSpawn4;
    public Transform shotSpawn5;
    public Transform shotSpawn6;
    public float fireRate;

    private float nextFire;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
		Fire ();
        Camera.main.transform.eulerAngles = new Vector3(0, 0, 0);
    }

    void FixedUpdate() {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetButton("Accelerate")) {
            rb.AddForce(transform.up * AccelerateForce);
        }
        if (Input.GetButton("Decelerate")) {
            rb.AddForce(transform.up * DecelerateForce);
        }
        rb.AddTorque(Input.GetAxis("Rotate") * torqueForce * Time.deltaTime);

        rb.position = new Vector2(
            Mathf.Clamp(rb.position.x, xMin, xMax),
            Mathf.Clamp(rb.position.y, yMin, yMax)
		);

    }
		
	void Fire() {
		if(Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn1.position, shotSpawn1.rotation);
			Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
			Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
		}
		if (Input.GetButton("Fire2") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn4.position, shotSpawn4.rotation);
			Instantiate(shot, shotSpawn5.position, shotSpawn5.rotation);
			Instantiate(shot, shotSpawn6.position, shotSpawn6.rotation);
		}
	}
}
