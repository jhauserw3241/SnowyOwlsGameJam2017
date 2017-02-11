using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class officeManager : MonoBehaviour {
    int seconds;
    int totSeconds = 60;

	// Use this for initialization
	void Start () {
        seconds = 0;
	}
	
	// Update is called once per frame
	void Update () {
        seconds++;
        if (seconds >= totSeconds) {
            SceneManager.LoadScene(5);
        }
	}
}
