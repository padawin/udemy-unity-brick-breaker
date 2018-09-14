using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallableBlock : _Brick {
	[SerializeField] float timeBeforeDestruct = 4f;

	private void OnCollisionEnter2D(Collision2D collision) {
		Rigidbody2D myRigibody = GetComponent<Rigidbody2D>();
		if (myRigibody.bodyType == RigidbodyType2D.Dynamic) {
			return;
		}
		playDestroySound();
		GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
		Destroy(gameObject, timeBeforeDestruct);
	}
}
