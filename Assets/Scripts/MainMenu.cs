using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	// Update is called once per frame
	void Update() {
		for (int index = 1; index < 10; index++) {
			if (
				Input.GetKeyDown(KeyCode.Alpha0 + index) ||
				Input.GetKeyDown(KeyCode.Keypad0 + index)
			) {
				FindObjectOfType<SceneLoader>().loadScene(index);
				break;
			}
		}
	}
}
