using UnityEngine;
using System.Collections;

public class Zeynep : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D obje) {
		
		if (Vector3.Distance (transform.position, obje.transform.position) < 1.2f) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}

	}
}


