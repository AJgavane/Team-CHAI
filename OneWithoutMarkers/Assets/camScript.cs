using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class camScript : MonoBehaviour {

    public GameObject webCameraPlane;
    public Button btnNext;

	// Use this for initialization
	void Start () {

        // Check if on the mobile platform
        if (Application.isMobilePlatform)
        {
            GameObject cameraParent = new GameObject("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate(Vector3.right, 90);
        }

        Input.gyro.enabled = true;

        btnNext.onClick.AddListener (OnButtonDown);

        // Create a new WebCamTexture
        WebCamTexture webCameraTexture = new WebCamTexture();
        // Take that texture and apply to the main webCameraPlane created in the scene
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        // Play the texture.
        webCameraTexture.Play();
	}
	
    void OnButtonDown()
    {
        GameObject slide = Instantiate(Resources.Load("slide", typeof(GameObject))) as GameObject;
        Rigidbody rb = slide.GetComponent<Rigidbody>();
        slide.transform.rotation = Camera.main.transform.rotation;
        slide.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 500f);
        Destroy(slide, 10);
    }

    // Update is called once per frame
    void Update () {
        Quaternion cameraRotation = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;
	}
}

