using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip destroySound;
	// cached reference of level
	Level level;
	GameStatus gameStatus;

	[SerializeField] int points = 0;

	void Start() {
		level = FindObjectOfType<Level>();
		gameStatus = FindObjectOfType<GameStatus>();
		level.addBrick();
	}

	protected void OnCollisionEnter2D(Collision2D collision) {
		addPoints(collision.gameObject.GetComponent<Ball>() != null);
	}

	void addPoints(bool hitByBall) {
		gameStatus.addPoints(points);
		if (!hitByBall) {
			gameStatus.addPoints(points);
		}
	}

	protected void remove(float timeBeforeRemoval) {
		playDestroySound();
		Destroy(gameObject, timeBeforeRemoval);
		level.removeBrick();
	}

	private void playDestroySound() {
		if (destroySound) {
			AudioSource.PlayClipAtPoint(destroySound, transform.position);
		}
	}
}
