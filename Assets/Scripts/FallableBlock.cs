using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallableBlock : _Brick {
	private new void OnCollisionEnter2D(Collision2D collision) {
		Rigidbody2D myRigibody = GetComponent<Rigidbody2D>();
		if (myRigibody.bodyType == RigidbodyType2D.Dynamic) {
			return;
		}
		base.OnCollisionEnter2D(collision);
		GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
	}
}
