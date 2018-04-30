using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/****************************************
 *  Enable switching between the scenes *
 ****************************************/

public class LevelManager : MonoBehaviour {
    
    // Use this for initialization
    public void LoadLevel(string name) //Public Method to change the scene with respect to scene name.
    {
        //Debug.Log ("New Level load: " + name);
        if (name != null)
        {
            Vibration.Vibrate(35);
            //Handheld.Vibrate();
            SceneManager.LoadScene(name);  // import  UnityEngine.SceneManagement;
        }
    }

    // Update is called once per frame
    public void RequestQuit () {
        Vibration.Vibrate(35);
        Application.Quit();
    }
}
