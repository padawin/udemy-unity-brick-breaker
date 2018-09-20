using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	KeyCode[] konami = {
		KeyCode.UpArrow, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.DownArrow,
		KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.LeftArrow, KeyCode.RightArrow,
		KeyCode.B, KeyCode.A
	};
	int currentKey = 0;

	// Update is called once per frame
	void Update() {
		if (currentKey == konami.Length) {
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
		else if (Input.GetKeyDown(konami[currentKey])) {
			currentKey++;
		}
		else if (Input.anyKeyDown) {
			currentKey = 0;
		}
	}
}
