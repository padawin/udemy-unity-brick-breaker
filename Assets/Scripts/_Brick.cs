using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip hitSound;
	[SerializeField] protected float timeBeforeDestruct = 0f;

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
		if (hits > hitSprites.Length) {
			addPoints(collision.gameObject.GetComponent<Ball>() != null ? 2 : 1);
			remove(timeBeforeDestruct);
		}
	}

	private void setNextHitSprite() {
		int spriteIndex = hits - 1;
		if (spriteIndex < hitSprites.Length) {
			if (hitSprites[spriteIndex] == null) {
				Debug.LogError(
					"Sprite at index " + spriteIndex +
					" is missing in object " + gameObject.name
				);
			}
			GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}

	void addPoints(int multiplier) {
		gameStatus.addPoints(points * multiplier);
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
