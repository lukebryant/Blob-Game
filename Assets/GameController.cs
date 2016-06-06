using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int score;
	public GUIText scoreText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore (int newScore)
	{
		score += newScore;
		UpdateScore();
	}	

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}
}
