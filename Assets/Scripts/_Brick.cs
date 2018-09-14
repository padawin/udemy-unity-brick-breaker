using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] AudioClip destroySound;

	protected void playDestroySound() {
		if (destroySound) {
			AudioSource.PlayClipAtPoint(destroySound, transform.position);
		}
	}
}
