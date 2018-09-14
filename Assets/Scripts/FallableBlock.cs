using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallableBlock : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D collision) {
		GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
		Destroy(gameObject, 4f);
	}
}
