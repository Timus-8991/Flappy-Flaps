using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {

    public static GameControlScript instance;

    public GameObject gameOverText;
    public GameObject gameOverText1;
    public bool GameOver = false;
    private int Score = 0;
    public Text scoreText;

    // Use this for initialization
    void Awake () {
		
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0) && GameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
		
	}

    public void BirdScored()
    {
        if(GameOver)
        {
            return;
        }

        Score++;
        scoreText.text = "Score : " + Score.ToString();

    }

    public void onBirdDied()
    {
        gameOverText.SetActive(true);

        gameOverText1.SetActive(true);
        GameOver = true;
    }
}
