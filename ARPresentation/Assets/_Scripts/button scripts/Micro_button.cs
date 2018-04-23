using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Micro_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        GetComponent<NavScript>().StartRotating(35);
        Debug.Log("Mircofilament clicked");
    }

}
