using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;


public class LevelController : MonoBehaviour
{
    public static LevelController Current;
    public bool gameActive = false;
    public GameObject startMenu, gameMenu, gameOverMenu, finishMenu,ucgen;
    public Text  nextLevelText;
    public TextMeshProUGUI finishScoreText,scoreText, currentLevelText;
    public ParticleSystem finishParticleRight, finishParticleLeft;
    public Slider levelProgressBar;
    public float maxDistance;
    public GameObject finishLine;
    public int currentLevel;
    private int currentLevell = 0;
    public int level = 1;
    public float score;
    
    
    void Start()
    {
        Current = this;
        currentLevel = PlayerPrefs.GetInt("currentLevel");
        currentLevell = PlayerPrefs.GetInt("currentLevell");
    }
    public void StartLevel()
    {
        currentLevelText.text = (currentLevell + 1).ToString();
        Debug.Log("Oyun Baþladý");
        //maxDistance = finishLine.transform.position.z - PlayerController.Current.transform.position.z;
        startMenu.SetActive(false);
        gameMenu.SetActive(true);
        gameActive = true;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        
        if (currentLevel == 2)
        {

            PlayerPrefs.SetInt("currentLevel", currentLevel - 2);
            currentLevel -= 2;
            SceneManager.LoadScene("Level " + currentLevel);
        }
        else
        {
            currentLevelText.text = (currentLevell + 1).ToString();
            SceneManager.LoadScene("Level " + (currentLevel + 1));
        }
        
    }

    public void GameOver()
    {
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        gameActive = false;
    }

    public void FinishMenu()
    {
        PlayerPrefs.SetInt("currentLevell", currentLevell + 1);
        PlayerPrefs.SetInt("currentLevel", currentLevel + 1);
        //finishParticle.Play();
        //finishScoreText.text = Ball.Current.score.ToString();
        gameMenu.SetActive(false);
        finishMenu.SetActive(true);
        gameActive = false;
    }

    public void ChangeScore(int Score)
    {
        score += Score;

        scoreText.text = score.ToString();
        finishScoreText.text = score.ToString();
    }

    public void ChangeMultiplicationScore(float ScoreX)
    {

        score *= ScoreX;
        score = (int)score;
        finishScoreText.text = score.ToString();
        finishParticleRight.Play();
        finishParticleLeft.Play();


    }
}
