using UnityEngine;

public class DestroyableBlock : _Brick {
	private void OnCollisionEnter2D(Collision2D collision) {
		Destroy(gameObject);
	}
}
