﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallableBlock : _Brick {
	private void OnCollisionEnter2D(Collision2D collision) {
		Rigidbody2D myRigibody = GetComponent<Rigidbody2D>();
		if (myRigibody.bodyType == RigidbodyType2D.Dynamic) {
			return;
		}
		if (!canBeBroken(collision.gameObject)) {
			return;
		}
		GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
		Destroy(gameObject, 4f);
	}
}
