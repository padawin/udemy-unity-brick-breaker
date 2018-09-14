using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Brick : MonoBehaviour {
	[SerializeField] float sqrMagnitudeThreshold = 4f;

	protected bool canBeBroken(GameObject collider) {
		Rigidbody2D colliderRigibody = collider.GetComponent<Rigidbody2D>();
		return colliderRigibody == null || colliderRigibody.velocity.sqrMagnitude >= sqrMagnitudeThreshold;
	}
}
