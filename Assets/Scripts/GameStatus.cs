using UnityEngine;

public class GameStatus : MonoBehaviour {
	[SerializeField] [Range(0f, 3f)] float gameSpeed = 1f;

	// Update is called once per frame
	void Update () {
		Time.timeScale = gameSpeed;
	}
}
