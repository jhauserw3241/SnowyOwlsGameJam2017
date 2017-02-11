using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    int speed = 5;
    //Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

            //TODO: Fix line 20 (need to convert this to GameObject)
            GameObject frontLegs = getChildGameObject(this,"FrontLeg");
            frontLegs.GetComponent<Animation>().Play("catWalking");
        }
	}

    // Taken from: http://answers.unity3d.com/questions/183649/how-to-find-a-child-gameobject-by-name.html
    static public GameObject getChildGameObject(GameObject fromGameObject, string withName)
    {
        //Author: Isaac Dart, June-13.
        Transform[] ts = fromGameObject.transform.GetComponentsInChildren();
        foreach (Transform t in ts) if (t.gameObject.name == withName) return t.gameObject;
        return null;
    }
}
