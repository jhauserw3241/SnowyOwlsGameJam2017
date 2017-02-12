using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Camera : MonoBehaviour {
    double start;
    private Vector3 pos;

    // Use this for initialization
    void Start () {
        start = Time.time;
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > (start + 21.0))
        {
            pos.x += 0.05f;
            transform.position = pos;
        }
	}
}
