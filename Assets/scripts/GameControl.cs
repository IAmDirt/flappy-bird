using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public Text scoreText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	private int score = 0;

	// Use this for initialization
	void Awake () 
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(gameOver == true && Input.GetMouseButtonDown (0))
			{
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
	}
	//får poeng vist han går igjennom stolpe
	public void BirdScored()
	{

		if (gameOver) 
		{
			return;
		}
		score++;
		scoreText.text = "score: " + score.ToString ();
		SoundManagerScript.PlaySound ("poeng");
	}

	//game over text, når du dør
	public void BirdDied()	
	{
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
