using UnityEngine;

public class GameStatus : MonoBehaviour {
	// Config
	[SerializeField] [Range(0f, 3f)] float gameSpeed = 1f;

	// State
	[SerializeField] int currentScore = 0;

	public void addPoints(int points) {
		currentScore += points;
	}

	// Update is called once per frame
	void Update () {
		Time.timeScale = gameSpeed;
	}
}
