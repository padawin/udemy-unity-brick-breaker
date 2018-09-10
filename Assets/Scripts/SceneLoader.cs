using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {
	public void loadNextScene() {
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex + 1);
	}

	public void loadFirstScene() {
		SceneManager.LoadScene(0);
	}

	public void loadScene(int index) {
		SceneManager.LoadScene(index);
	}

	public void quit() {
		Application.Quit();
	}
}
