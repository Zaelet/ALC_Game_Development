using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnManager : MonoBehaviour
{

    public GameObject[] balloonPrefabs; // get the array of balloons
    public float startDelay = 0.5f; // time before first balloon
    public float spawnInterval = 1.5f; // time between balloon spawns
    public float xRange = 10.0f;
    public float zRange = 5.0f;
    public float yPos = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
        //get random position on the x axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, Random.Range(-zRange, zRange));
        // pick a random balloon from our array of prefabs
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        // spawn the random balloon at the random position we chose
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
