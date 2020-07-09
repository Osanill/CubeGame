using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
   public Rigidbody rb;
   public int force = 1000;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, - force * Time.deltaTime);
    }
}
