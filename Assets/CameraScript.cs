using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript: MonoBehaviour 
{
	public const float speedH = 5f;
	public const float speedV = 5f;
	private float yaw = 0.0f;
    private float pitch = 0.0f;
    private const byte limite = 35;

    GameObject Camera = new GameObject();
    

	void Update () 
	{
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
        

            if (pitch >limite)
            {
                pitch = limite;
            }
            else if (pitch < -limite)
            {
                pitch = -limite;
            }
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
            //Camera.transform.Rotate(new Vector3(pitch, yaw, 0.0f));
    }
}

