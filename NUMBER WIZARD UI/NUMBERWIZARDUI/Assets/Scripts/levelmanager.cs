﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

	// Use this for initialization
    
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("game");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("start");
    }


}
