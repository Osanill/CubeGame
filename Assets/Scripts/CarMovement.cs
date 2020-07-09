using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
	public Rigidbody rb;
    public int sidewayForce = 1000;
	public Transform carPosition;

	bool gameHasEnded = false;
	// Update is called once per frame
    void FixedUpdate()
    {
		if(Input.GetKey("right")){
			rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(Input.GetKey("left")){
			rb.AddForce(- sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

				
		if(carPosition.position.y < -1)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
    }
}
