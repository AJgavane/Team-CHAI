using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyto_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick(string sceneName)
    {
        GetComponent<NavScript>().StartRotating(107, sceneName);
        Debug.Log("Cytoplasm clicked");
    }

}
