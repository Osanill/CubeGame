using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text ScoreText;

	private int timer;
	private double score;

	void Update () {
		score = score + (0.25);
		//timer += Time.deltaTime;
		ScoreText.text = score.ToString("0");	
	}
}
