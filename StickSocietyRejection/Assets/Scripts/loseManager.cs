﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseManager : MonoBehaviour {

    public void onTryAgainClick()
    {
        SceneManager.LoadScene(6);
    }

    public void onQuitClick()
    {
        Application.Quit();
    }
}
