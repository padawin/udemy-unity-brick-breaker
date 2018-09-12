using UnityEngine;

public class Ball : MonoBehaviour {
	[SerializeField] Paddle paddle;

	Vector2 distanceFromPaddle;

	// Use this for initialization
	void Start () {
		distanceFromPaddle = transform.position - paddle.transform.position;
	}

	// Update is called once per frame
	void Update () {
		Vector2 newPos = new Vector2(
			paddle.transform.position.x,
			paddle.transform.position.y
		);
		transform.position = newPos + distanceFromPaddle;
	}
}
