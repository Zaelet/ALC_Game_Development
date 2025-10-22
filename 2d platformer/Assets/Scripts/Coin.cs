using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;
using System;
public class Coin : MonoBehaviour
{
    public int scoreToGive; // how many points to increase by
    private float startYpos; // define the coins starting Y-value
    public float bobHeight; // how high up and down the coin will bob
    public float bobSpeed; // how often will it bob up and down

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touched coin");
        if (collision.CompareTag("Player"))
        {
            //add to score and then delete self
            collision.GetComponent<PlayerController2D>().AddScore(scoreToGive);
            Destroy(gameObject);
        }
    }
  
    void Start()
    {
        startYpos = transform.position.y; // set start position to current y position
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startYpos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }
}
