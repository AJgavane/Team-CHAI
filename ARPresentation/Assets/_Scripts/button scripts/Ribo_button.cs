﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribo_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick(string sceneName)
    {
        GetComponent<NavScript>().StartRotating(322, sceneName);
        Debug.Log("Ribosome clicked");
    }

}
