using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Controller : MonoBehaviour
{
    public float speed; // vroom
    public float rotSpeed; // speed of rotation of the controller

    public float hInput; //store values for horizontal movement
    public float vInput; //store values for vertical movement

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); // makes the vehichle rotate left to right
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime); // makes the vehichle move forwards and back 
    }
}
