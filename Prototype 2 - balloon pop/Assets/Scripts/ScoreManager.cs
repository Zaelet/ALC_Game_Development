using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; // include the UI textmesh pro stuff 

public class ScoreManager : MonoBehaviour
{
    public int score; // keep track of the score
    public TextMeshProUGUI scoreText; // reference Text ui object to display and update

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; // increase score by amount
        UpdateScoreText(); // update score UI text to match score
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; // decrease score by amount
        UpdateScoreText(); // update score UI text to match score
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

}
