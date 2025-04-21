using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour {

    private void Update() {
        if (Input.GetKeyDown(KeyCode.T)) {
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Y)) {
            Time.timeScale = 20f;
        }
        if (Input.GetKeyDown(KeyCode.U)) {
            Time.timeScale = 50f;
        }
    }

}
