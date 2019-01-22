using System.Collections;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
    }
}
