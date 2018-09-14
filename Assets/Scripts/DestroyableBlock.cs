using UnityEngine;

public class DestroyableBlock : _Brick {
	private void OnCollisionEnter2D(Collision2D collision) {
		if (canBeBroken(collision.gameObject)) {
			Destroy(gameObject);
		}
	}
}
