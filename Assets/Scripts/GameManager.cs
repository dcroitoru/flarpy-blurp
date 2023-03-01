using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int score;

    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        foreach(Pipes pipe in pipes)
        {
            Destroy(pipe.gameObject);
        }


    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        Debug.Log("should increase score");
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        Debug.Log("should show game over");
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
}
