﻿/*########################################################################################
#                                                                                         #
# File:    Gyroscope.cs                                                    			      #
# Version: Release 01.00                                                                  #
# Date :   June 2017                                                             	      #
#                                                                                	      #
#                                                                                         #
# Purpose – To demonstrate see-through capability as well as the gyroscopic values.       #
#			The virtual Earth can be observed along with the real object around the users.#
#     																				      #
# Note:     This script has been designed for Moverio for Andriod, release 5.1 & above.   #
#           Do not attempt to run this script in earlier versions of Andriod.         	  #
#                                                                                         #
# Copyright 2017 Seiko Epson Corporation. All rights reserved.            		          #
#                                                                                         #
#########################################################################################*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyroscope : MonoBehaviour 
{

	#region DecraledVariables
	// Use this for initialization
	[SerializeField]
	Text TitleText;

	[SerializeField]
	Toggle tglBtn;

	[SerializeField]
	GameObject camera;

	[SerializeField]
	GameObject animalCell;

	[SerializeField]
	float speed;

    [SerializeField]
    float deltaScale = 0.05f;
    float scale ;


    private int TYPE_CONTROLLER_GYROSCOPE = 3;

	#endregion

	void Update () 
	{
        
		if (MoverioController.Instance.MoverioDevice == true)
		{



            //if (tglbtn.ison == true) //switching between head tracking and controller tracking
            //{

            //    camera.getcomponent<headtrackingar>().enabled = false;  //disabling the headset gyroscope.
            //    titletext.text = "gyro controller : " + mathf.round(moveriocontroller.instance.getsensordata(type_controller_gyroscope)[0]).tostring() + ", " +
            //", " + mathf.round(moveriocontroller.instance.getsensordata(type_controller_gyroscope)[1]).tostring() + ", " +
            //", " + mathf.round(moveriocontroller.instance.getsensordata(type_controller_gyroscope)[2]).tostring();

            //    camera.transform.rotate(-moveriocontroller.instance.getsensordata(type_controller_gyroscope)[0] * 5f, -moveriocontroller.instance.getsensordata(type_controller_gyroscope)[1] * 5f, 0); //enabling the controller gyroscope.

            //}
            //else
            {
                camera.GetComponent<HeadTrackingAR> ().enabled = true; //Enabling the headset gyroscope.
		    }

		}
	}

	void FixedUpdate()
	{
        Vector3 position = animalCell.transform.localPosition;
        float scaleValue = animalCell.transform.localScale.x;
       Debug.Log(scaleValue);
        if (scaleValue  > 1.1)
        {
            deltaScale *= -1;
        }
        else if( scaleValue  < 0.98f)
        {
            deltaScale *= -1;
        }

        //animalCell.transform.position = new Vector3(-position.x, -position.y, -position.z);
        //animalCell.transform.localScale += new Vector3(deltaScale, deltaScale, 0);
        //animalCell.transform.position = new Vector3(position.x, position.y, position.z);

        //animalCell.transform.Rotate (rotateValue);//a linear rotation for the animal on it's own axis
    }
}
