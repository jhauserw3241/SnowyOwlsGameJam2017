using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroConv : MonoBehaviour {
    void Start() {

    }

    void Update() {
        if (Time.time > GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length)
        {
            SceneManager.LoadScene(6);
        }
    }
}
