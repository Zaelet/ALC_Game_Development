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
        
        if (collision.CompareTag("Player")) //if the player touched me continue
        {
            
            //check if current level is final level, go to next level/menu
            if (finalLevel == true)
            {
                animator.SetBool("OpenDoor", true); //open door is now true
                //if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor")) if the animator is currently playing OpenDoor load the scene
                //{
                    SceneManager.LoadScene(0);
                //}
                //set open door to false and rerun?
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
