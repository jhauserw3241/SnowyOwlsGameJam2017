using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerManager : MonoBehaviour {
    double start;

    // Use this for initialization
    void Start()
    {
        start = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > (start + 21.0)) {
            GetComponent<Text>().text = (GetTimerValue()).ToString();
        }

        if (((Time.time - start) > 60.0) && (GetComponent<Text>().text != "")) {
            GetComponent<Text>().text = ("");
        }
    }

    double GetTimerValue() {
        return 60.0 - (Time.time - start);
    }
}
