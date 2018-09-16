using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip hitSound;
	[SerializeField] protected float timeBeforeDestruct = 0f;
	[SerializeField] int hitsToBreak = 1;

	// cached reference of level
	Level level;
	GameStatus gameStatus;

	[SerializeField] int points = 0;
	[SerializeField] Sprite[] hitSprites;
	int hits = 0;

	protected void Start() {
		level = FindObjectOfType<Level>();
		gameStatus = FindObjectOfType<GameStatus>();
		if (tag != "unbreakable") {
			level.addBrick();
		}
	}

	protected void OnCollisionEnter2D(Collision2D collision) {
		if (tag != "unbreakable") {
			handleHit(collision);
		}
		playHitSound();
	}

	private void handleHit(Collision2D collision) {
		hits++;
		setNextHitSprite();
		if (hits >= hitsToBreak) {
			addPoints(collision.gameObject.GetComponent<Ball>() != null);
			remove(timeBeforeDestruct);
		}
	}

	private void setNextHitSprite() {
		if (hits <= hitSprites.Length) {
			GetComponent<SpriteRenderer>().sprite = hitSprites[hits - 1];
		}
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
