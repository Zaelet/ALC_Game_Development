using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("Player"))
        {
            if (finalLevel == true)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(nextLevelName);
            }

        }

    } 
}
