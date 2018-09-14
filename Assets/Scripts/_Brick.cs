using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip destroySound;
	// cached reference of level
	Level level;

	void Start() {
		level = FindObjectOfType<Level>();
		level.addBrick();
	}

	protected void remove(float timeBeforeRemoval) {
		level.removeBrick();
		playDestroySound();
		Destroy(gameObject, timeBeforeRemoval);
	}

	private void playDestroySound() {
		if (destroySound) {
			AudioSource.PlayClipAtPoint(destroySound, transform.position);
		}
	}
}
