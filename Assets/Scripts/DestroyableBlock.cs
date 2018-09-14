using UnityEngine;

public class DestroyableBlock : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D collision) {
		Destroy(gameObject);
	}
}
