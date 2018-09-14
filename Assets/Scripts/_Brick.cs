using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip destroySound;

	protected void remove(float timeBeforeRemoval) {
		playDestroySound();
		Destroy(gameObject, timeBeforeRemoval);
	}

	private void playDestroySound() {
		if (destroySound) {
			AudioSource.PlayClipAtPoint(destroySound, transform.position);
		}
	}
}
