using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

    public static GameController instance;
    public Text scoreText;
    public GameObject gameOvertext;

    private int score = 0;
    public bool gameOver = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
    public void PlayerScored()
    {
        if (gameOver) return;
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
    public void PlayerDied()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}
