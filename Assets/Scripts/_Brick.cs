using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip hitSound;
	[SerializeField] protected float timeBeforeDestruct = 0f;

	// cached reference of level
	Level level;
	GameStatus gameStatus;

	[SerializeField] int points = 0;

	protected void Start() {
		level = FindObjectOfType<Level>();
		gameStatus = FindObjectOfType<GameStatus>();
		level.addBrick();
	}

	protected void OnCollisionEnter2D(Collision2D collision) {
		addPoints(collision.gameObject.GetComponent<Ball>() != null);
		remove(timeBeforeDestruct);
		playHitSound();
	}

	void addPoints(bool hitByBall) {
		gameStatus.addPoints(points);
		if (!hitByBall) {
			gameStatus.addPoints(points);
		}
	}

	protected void remove(float timeBeforeRemoval) {
		Destroy(gameObject, timeBeforeRemoval);
		level.removeBrick();
	}

	private void playHitSound() {
		if (hitSound) {
			AudioSource.PlayClipAtPoint(hitSound, transform.position);
		}
	}
}
