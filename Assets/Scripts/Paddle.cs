using UnityEngine;

public class Paddle : MonoBehaviour {
	[SerializeField] float screenWidthInUnits = 16f;
	[SerializeField] float minPosX = 1;
	[SerializeField] float maxPosX = 16;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float newX = Mathf.Clamp(
			Input.mousePosition.x / Screen.width * screenWidthInUnits,
			minPosX, maxPosX
		);
		Vector2 newPos = new Vector2(newX, transform.position.y);
		transform.position = newPos;
	}
}
