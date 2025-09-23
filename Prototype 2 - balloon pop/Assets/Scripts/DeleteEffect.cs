using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeleteEffect : MonoBehaviour
{
    public int timer = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer); // adds a timer that counts down before destroying
    }

}
