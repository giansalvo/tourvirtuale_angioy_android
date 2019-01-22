using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CameraScript1 : MonoBehaviour {
 
public GameObject Camera1;
public GameObject Camera2;
public GameObject Camera3;
    
public void Enablefirst()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }
public void EnableCamera1() 
	{
	Camera1.SetActive(true);
	Camera2.SetActive(false);
	Camera3.SetActive(false);

    }
public void EnableCamera2() 
	{
        Camera1.SetActive(false);
	Camera2.SetActive(true);
	Camera3.SetActive(false);
    }
public void EnableCamera3() 
	{
	Camera1.SetActive(false);
	Camera2.SetActive(false);
	Camera3.SetActive(true);

    }

}

		



