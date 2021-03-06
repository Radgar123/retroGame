﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointController : MonoBehaviour
{
    public static int scoreValue;
    [SerializeField] private int highScore;

    public Text score = null;
    public TextMeshProUGUI highS;

    public bool isActiveScore;
    public bool isActiveHighScore;

    

    void Start() 
    {
        scoreValue = 0;
        //score = GetComponent<Text>();
    }

    void Update()
    {
        score = GameObject.FindWithTag("score").GetComponent<Text>();

        CheckHighScore();

        if (isActiveScore)
            GetScoreText();

        if (isActiveHighScore)
            GetHighScoreText();

    }

    void CheckHighScore() 
    {
        if (scoreValue > highScore) 
        {
            highScore = scoreValue;
        }
    }

    void GetScoreText() 
    {
        score.text = "Score: " + scoreValue;
    }

    void GetHighScoreText() 
    {
        highS.text = "High Score: " + highScore; 
    }


}
