using UnityEngine;

public class DestroyableBlock : _Brick {
	[SerializeField] GameObject destroySparkles;

	private new void OnCollisionEnter2D(Collision2D collision) {
		base.OnCollisionEnter2D(collision);
		remove(0f);
		triggerSparkles();
	}

	private void triggerSparkles() {
		GameObject sparkles = Instantiate(destroySparkles, transform.position, transform.rotation);
		Destroy(sparkles, 1f);
	}
}
