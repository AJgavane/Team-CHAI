﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuc_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        GetComponent<NavScript>().StartRotating(288);
        Debug.Log("Nucleus clicked");
    }

}
