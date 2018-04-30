using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatMotion : MonoBehaviour {
    #region DecraledVariables
    // Use this for initialization
    [SerializeField]
    GameObject camera;

    [SerializeField]
    GameObject organelle;

    [SerializeField]
    float maxScale;

    [SerializeField]
    float minScale;

    [SerializeField]
    float deltaScale;

    #endregion

   
	// Update is called once per frame
	void Update () {
        Vector3 position = organelle.transform.localPosition;
        //Debug.Log(position.x + ", " + position.y + ", " + position.z);
        float scaleValue = organelle.transform.localScale.x;
        //Debug.Log(scaleValue);
        if (scaleValue > maxScale)
        {
            deltaScale *= -1;
        }
        else if (scaleValue < minScale)
        {
            deltaScale *= -1;
        }

       // organelle.transform.position = new Vector3(-position.x, -position.y, -position.z);
        organelle.transform.localScale += new Vector3(deltaScale, deltaScale, deltaScale);
       // organelle.transform.position = new Vector3(position.x, position.y, position.z);

       // organelle.transform.Rotate (rotateValue);//a linear rotation for the animal on it's own axis
    }


}
