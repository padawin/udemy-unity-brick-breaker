using UnityEngine;

public class LoseCollider : MonoBehaviour {
	[SerializeField] SceneLoader sceneLoader;

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.name != "Ball") {
			return;
		}
		sceneLoader.loadSceneFromName("EndGame");
	}
}
