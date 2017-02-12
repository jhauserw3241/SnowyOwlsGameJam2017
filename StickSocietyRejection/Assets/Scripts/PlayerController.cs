using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    int speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Kill player if too far off left or bottom side of screen
        if ((Camera.main.WorldToViewportPoint(transform.position).x <= 0.2) ||
            (Camera.main.WorldToViewportPoint(transform.position).y <= -0.2)) {
            DeathIsUponUs();
        }

        // Handle walking right
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            runWalkingAnimation();
        }
        // Handle walking left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            runWalkingAnimation();
        }
        // Handle jumping
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            runJumpingAnimation();
        }
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Scarf") {
            runWinProcess();
        }

        if (coll.gameObject.tag == "Poison") {
            DeathIsUponUs();
        }
    }

    void runWalkingAnimation() {
        //TODO: Fix line 20 (need to convert this to GameObject)
        //GameObject frontLegs = getChildGameObject(this,"FrontLeg");
        //frontLegrunJumpingAnimations.GetComponent<Animation>().Play("catWalking");
    }

    void runJumpingAnimation() {
        //TODO: Fix line 20 (need to convert this to GameObject)
        //GameObject frontLegs = getChildGameObject(this,"FrontLeg");
        //frontLegs.GetComponent<Animation>().Play("catWalking");
    }

    void runWinProcess() {

        // Go to win scene
        SceneManager.LoadScene(2);
    }

    void DeathIsUponUs() {
        SceneManager.LoadScene(3);
    }

    //// Taken from: http://answers.unity3d.com/questions/183649/how-to-find-a-child-gameobject-by-name.html
    //static public GameObject getChildGameObject(GameObject fromGameObject, string withName)
    //{
    //    //Author: Isaac Dart, June-13.
    //    Component[] cs = fromGameObject.transform.GetComponentsInChildren();
    //    foreach (Component t in cs) if (t.gameObject.name == withName) return t.gameObject;
    //    return null;
    //}
}
