using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
	int countBricks = 0;

	public void addBrick() {
		countBricks++;
	}

	public void removeBrick() {
		countBricks--;
	}

	// Update is called once per frame
	void Update () {
		if (countBricks == 0) {
			FindObjectOfType<SceneLoader>().loadNextScene();
		}
	}
}
