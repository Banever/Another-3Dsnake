using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text ScoreText;
    public Text HighScoreText;

    int Score = 0;
    int HighScore = 0;

    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        ScoreText.text = Score.ToString() + " Fruits Eaten";
        HighScoreText.text = "HighScore " + HighScore.ToString();
    }

    public void AddPoint()
    {
        Score += 1;
        ScoreText.text = Score.ToString() + " Fruits Eaten";
        if (HighScore < Score)
            PlayerPrefs.SetInt("HighScore", Score);
    }

}
