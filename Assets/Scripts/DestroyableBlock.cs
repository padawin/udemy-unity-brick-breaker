using UnityEngine;

public class DestroyableBlock : _Brick {
	[SerializeField] GameObject destroySparkles;

	new void Start() {
		base.Start();
		timeBeforeDestruct = 0f;
	}

	private new void OnCollisionEnter2D(Collision2D collision) {
		base.OnCollisionEnter2D(collision);
		triggerSparkles();
	}

	private void triggerSparkles() {
		if (destroySparkles == null) {
			return;
		}
		GameObject sparkles = Instantiate(destroySparkles, transform.position, transform.rotation);
		Destroy(sparkles, 1f);
	}
}
