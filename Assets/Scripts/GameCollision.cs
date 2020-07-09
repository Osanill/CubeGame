using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCollision : MonoBehaviour
{
	public GameObject[] cubes;
	public CarMovement car;
	void OnCollisionEnter(Collision other)
	{
		if(other.collider.tag == "Cube") 
		{
			foreach(GameObject cube in cubes)
			{
				cube.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
				cube.gameObject.GetComponent<CubeMovement>().force = 0;
				car.sidewayForce = 0;			
			}
			FindObjectOfType<GameManager>().EndGame();
		}
	
		if(other.collider.tag == "End")
		{
			other.collider.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			FindObjectOfType<GameManager>().CompleteLevel();
			car.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}
}
