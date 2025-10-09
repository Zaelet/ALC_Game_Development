using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagment;
using TMPro;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player Settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4; // killbox
    [Header("Score")]
    public int score;

    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;
   
    public void AddScore (int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
    // fixed update for consistant movement
    void FixedUpdate ()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.velocity = new Vector2(moveInput * moveSpeed, rig.velocity.y);
        
    }
    // update for reactive jumps
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // impulse applies force in a burst, great for jumps
        }

        //Killbox
        if (transform.posistion.y < bottomBound)
        {
            GameOver();
        }
    }
    // check if touching ground
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
