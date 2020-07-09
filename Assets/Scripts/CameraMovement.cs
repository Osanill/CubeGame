using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public Transform car;
   public Vector3 vector;

    // Update is called once per frame
    void Update()
    {
		transform.position = car.position + vector;       
    }
}
