using UnityEngine;
using System.Collections;

public class DestroyByBoundery : MonoBehaviour {
    void OnTriggerExit(Collider other) {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
    }
}
