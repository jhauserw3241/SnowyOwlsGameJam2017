using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour {

    public void onStartClick() {
        SceneManager.LoadScene(5);
    }

    public void onCreditsClick()
    {
        SceneManager.LoadScene(4);
    }

    public void onQuitClick()
    {
        Application.Quit();
    }
}
