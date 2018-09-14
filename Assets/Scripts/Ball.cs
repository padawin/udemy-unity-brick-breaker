﻿using UnityEngine;

public class Ball : MonoBehaviour {
	[SerializeField] Paddle paddle;
	[SerializeField] float speed = 5f;
	[SerializeField] AudioClip[] sounds;

	Vector2 distanceFromPaddle;
	float velocityAdjustmentThreshold = 0.001f;
	bool isLaunched = false;

	// Cached audio source
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		distanceFromPaddle = transform.position - paddle.transform.position;
		audioSource = GetComponent<AudioSource>();
	}

	void lockOnPaddle() {
		Vector2 newPos = new Vector2(
			paddle.transform.position.x,
			paddle.transform.position.y
		);
		transform.position = newPos + distanceFromPaddle;
	}

	void launch() {
		float initialAngle = Random.Range(Mathf.PI / 6, 5 * Mathf.PI / 6);
		GetComponent<Rigidbody2D>().velocity = new Vector2(
			speed * Mathf.Cos(initialAngle),
			speed * Mathf.Sin(initialAngle)
		);
	}

	// Update is called once per frame
	void Update() {
		if (!isLaunched) {
			lockOnPaddle();
			if (Input.GetMouseButtonDown(0))
			{
				launch();
				isLaunched = true;
			}
		}
		else {
			Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
			if (Mathf.Abs(velocity.y) < velocityAdjustmentThreshold) {
				velocity.y = Random.Range(-1, 1);
			}
			velocity.Normalize();
			GetComponent<Rigidbody2D>().velocity = velocity * speed;
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (isLaunched) {
			if (audioSource) {
				AudioClip clip = sounds[Random.Range(0, sounds.Length)];
				audioSource.PlayOneShot(clip);
			}
		}
	}
}
