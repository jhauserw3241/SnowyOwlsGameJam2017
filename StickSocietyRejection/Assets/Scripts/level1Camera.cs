using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Camera : MonoBehaviour {
    int currentTick;
    static int rate = 5; // This is seconds per ft movement

	// Use this for initialization
	void Start () {
        currentTick = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTick++;

		if ((currentTick % 5) == 0) {
            transform.Translate(new Vector3(rate * Time.deltaTime, 0, 0));
        }
	}
}
