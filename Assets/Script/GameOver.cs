using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject Score1;
    private Score scoremanager;
    AudioSource audiosrc;

    // Update is called once per frame

    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        scoremanager = FindObjectOfType<Score>();
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
            audiosrc.Play();
            Time.timeScale = 0;
            scoremanager.scoreIncreasing = false;
            Score1.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        scoremanager.scoreCount = 0;
        scoremanager.scoreIncreasing = true;
    }
}

