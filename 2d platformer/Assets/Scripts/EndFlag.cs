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
            if (finalLevel == true)
            {
                animator.SetBool("OpenDoor", true);
                //if( this.animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor") )
                //{
                   SceneManager.LoadScene(0); 
               // }
                
            }
            else
            {
                animator.SetBool("OpenDoor", true);
                //if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor"))
               // {
                    SceneManager.LoadScene(nextLevelName);
               // }
            }
        }

    } 
}
