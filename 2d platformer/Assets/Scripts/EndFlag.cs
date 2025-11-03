using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public string nextLevelName;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
         animator.SetBool("OpenDoor", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            animator.SetBool("OpenDoor", true);
        }
        else
        {
            animator.SetBool("OpenDoor", false);
        }
        
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
