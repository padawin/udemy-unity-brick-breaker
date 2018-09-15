using UnityEngine;

public class DestroyableBlock : _Brick {
	private new void OnCollisionEnter2D(Collision2D collision) {
		base.OnCollisionEnter2D(collision);
		remove(0f);
	}
}
