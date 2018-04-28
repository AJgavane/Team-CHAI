using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavScript : MonoBehaviour {

    Quaternion startRotation;
    Quaternion endRotation;
    float rotationProgress = -1;
    string m_sceneName = null;
    LevelManager levelManager = new LevelManager();
    // Use this for initialization
    void Start () {
		
	}
    // Call this to start the rotation
    public void StartRotating(float zPosition)
    {

        // Here we cache the starting and target rotations
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zPosition);

        // This starts the rotation, but you can use a boolean flag if it's clearer for you
        rotationProgress = 0;
    }
    // Call this to start the rotation
    public void StartRotating(float zPosition, string sceneName)
    {

        // Here we cache the starting and target rotations
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zPosition);
        m_sceneName = sceneName;
        // This starts the rotation, but you can use a boolean flag if it's clearer for you
        rotationProgress = 0;
    }

    // Update is called once per frame
    void Update () {
        
        if (rotationProgress < 1 && rotationProgress >= 0)
        {
            float rotate = endRotation.eulerAngles.z - startRotation.eulerAngles.z;
            if(rotate < 0)
            {
                rotate = 360 + rotate;
            }
            if ( rotate > 90 && rotate < 270)
            {
                rotationProgress += Time.deltaTime * (float).6;
            }
            else
            {
                rotationProgress += Time.deltaTime * 2;
            }
            // Here we assign the interpolated rotation to transform.rotation
            // It will range from startRotation (rotationProgress == 0) to endRotation (rotationProgress >= 1)
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, rotationProgress);
        }
        else
        {
            levelManager.LoadLevel(m_sceneName);
        }
    }
}
