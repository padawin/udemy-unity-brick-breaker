using UnityEngine;

public class DestroyableBlock : _Brick {
	private void OnCollisionEnter2D(Collision2D collision) {
		remove(0f);
	}
}
