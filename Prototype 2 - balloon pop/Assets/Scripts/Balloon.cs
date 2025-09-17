using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;
public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // how many clicks to pop

    public float scaleToIncrease = 0.15f; // how much to inflate the balloon on click

    public int scoreToGive; // how much to increase score by on pop

    private ScoreManager scoreManager; // A variable to reference the Scoremanager

    public GameObject popEffect; // Reference pop effect particle system

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
       
        clickToPop -= 1; //reduce clicks by one
        transform.localScale += Vector3.one * scaleToIncrease; //increase balloon size

        if (clickToPop == 0) //check to see if the balloon has popped
        {
            scoreManager.IncreaseScoreText(scoreToGive); // Increase score
            Destroy(gameObject); // pop the balloon
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
