using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_button : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick(string sceneName)
    {
        GetComponent<NavScript>().StartRotating(70, sceneName);
        Debug.Log("Cell Wall clicked");
    }
}
