using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingManager : MonoBehaviour {
    int currentSec;
    int totalSecs = 20;

	// Use this for initialization
	void Start () {
        currentSec = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentSec++;

        if (currentSec >= totalSecs) {
            SceneManager.LoadScene(1);
        }
	}
}
