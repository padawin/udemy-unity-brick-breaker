using UnityEngine;

public class SpeedBlock : _Brick {
	[SerializeField] float multiplier = 1f;

	private new void OnCollisionEnter2D(Collision2D collision) {
		base.OnCollisionEnter2D(collision);
		Ball ball = FindObjectOfType<Ball>();
		ball.multiplySpeed(multiplier);
	}
}
