using UnityEngine;

public class Explosion : MonoBehaviour {
	[SerializeField] float duration = 5f;
	[SerializeField] float expansionSpeed = .1f;
	[SerializeField] Color colorFrom;
	[SerializeField] Color colorTo;

	float timeBirth;
	Vector2 initialPosition;

	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
		timeBirth = Time.time;
		transform.localScale = new Vector2(0, 0);
		colorFrom.a = 1f;
		colorTo.a = 1f;
		GetComponent<SpriteRenderer>().color = colorFrom;
		Destroy(gameObject, duration);
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = initialPosition;
		float progress = (Time.time - timeBirth) / duration;
		transform.localScale = new Vector2(
			transform.localScale.x + expansionSpeed,
			transform.localScale.y + expansionSpeed
		);
		Color c = new Color(
			Mathf.Lerp(colorFrom.r, colorTo.r, progress),
			Mathf.Lerp(colorFrom.g, colorTo.g, progress),
			Mathf.Lerp(colorFrom.b, colorTo.b, progress),
			1f
		);
		GetComponent<SpriteRenderer>().color = c;
	}
}
