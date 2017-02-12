using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class officeManager : MonoBehaviour {
    int seconds;
    int totSeconds = 60;

    Dictionary<KeyValuePair<int, int>, string> animationSequence; // Start, end, animation name

	// Use this for initialization
	void Start () {
        seconds = 0;

        animationSequence = new Dictionary<KeyValuePair<int, int>, string>();
        animationSequence.Add(new KeyValuePair<int, int>(5, 15), "wizard_1");
        animationSequence.Add(new KeyValuePair<int, int>(15, 25), "jill_1a");
        animationSequence.Add(new KeyValuePair<int, int>(25, 35), "jill_1b");
        animationSequence.Add(new KeyValuePair<int, int>(35, 45), "jill_1c");
        animationSequence.Add(new KeyValuePair<int, int>(45, 55), "wizard_2");
        animationSequence.Add(new KeyValuePair<int, int>(55, 65), "jill_2a");
        animationSequence.Add(new KeyValuePair<int, int>(65, 75), "jill_2b");
        animationSequence.Add(new KeyValuePair<int, int>(75, 85), "wizard_3");
        animationSequence.Add(new KeyValuePair<int, int>(85, 90), "wizard_3b");
        animationSequence.Add(new KeyValuePair<int, int>(90, 100), "jill_3a");
        animationSequence.Add(new KeyValuePair<int, int>(100, 110), "jill_3b");
        animationSequence.Add(new KeyValuePair<int, int>(110, 120), "wizard_4");
        animationSequence.Add(new KeyValuePair<int, int>(120, 130), "jill_4a");
        animationSequence.Add(new KeyValuePair<int, int>(130, 140), "jill_4b");
        animationSequence.Add(new KeyValuePair<int, int>(140, 150), "wizard_5a");
        animationSequence.Add(new KeyValuePair<int, int>(150, 160), "wizard_5b");
    }
	
	// Update is called once per frame
	void Update () {
        seconds++;

        foreach(KeyValuePair<KeyValuePair<int, int>, string> obj in animationSequence) {
            KeyValuePair<int, int> timeInfo = obj.Key;
            runAnimation(timeInfo.Key, timeInfo.Value, obj.Value);
        }

        if (seconds >= totSeconds) {
            SceneManager.LoadScene(6);
        }
	}

    void runAnimation(int start, int end, string name) {
        GameObject obj = GameObject.FindGameObjectWithTag(name);
        Debug.Log(obj.name);

        if ((seconds == 0) && 
            (obj.activeSelf)) {
            obj.SetActive(false);
        }

        if ((start >= seconds) &&
            (end <= seconds) &&
            (!obj.activeSelf))
        {
            obj.SetActive(true);
        }

        if ((end > seconds) &&
            (obj.activeSelf)) {
            obj.SetActive(false);
        }
    }
}
