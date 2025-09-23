using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveUp : MonoBehaviour
{

    public float speed = 3.0f;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager; // reference score manager
    public Balloon balloon; // reference balloon script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // move the balloon at a constant rate (speed) up on the y axis

        if (transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); //reduces score
            Destroy(gameObject); // pops baloons that leave the screen
        }
    }
}
