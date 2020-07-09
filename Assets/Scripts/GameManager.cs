using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	bool gameHasWon = false;
	public float delay = 0.5f; 
	public GameObject levelComplete;
	public GameObject score;
	public void EndGame()
	{
		if(gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("Game Overr");	
			Invoke("Restart", delay);
		}
	}

	public void CompleteLevel()
	{
		if(gameHasWon == false)
		{
			gameHasWon = true;
			Debug.Log("Won");
		}
		score.SetActive(false);
		levelComplete.SetActive(true);
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
