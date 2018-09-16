using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {
	// Config
	[SerializeField] [Range(0f, 3f)] float gameSpeed = 1f;
	[SerializeField] bool resetOnStart = false;

	// State
	static int currentScore = 0;
	[SerializeField] TextMeshProUGUI scoreText;

	public void addPoints(int points) {
		currentScore += points;
		scoreText.text = currentScore.ToString();
	}

	void Start() {
		if (resetOnStart) {
			currentScore = 0;
		}
		scoreText.text = currentScore.ToString();
	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = gameSpeed;
	}
}
