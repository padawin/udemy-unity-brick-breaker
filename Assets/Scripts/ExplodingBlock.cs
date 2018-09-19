using UnityEngine;

public class ExplodingBlock : _Brick {
	[SerializeField] Explosion explosion;

	private new void OnCollisionEnter2D(Collision2D collision) {
		base.OnCollisionEnter2D(collision);
		Instantiate(explosion, transform.position, transform.rotation);
	}
}
