using UnityEngine;
public class MoveUp : MonoBehaviour
{

    public float speed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // move the balloon at a constant rate (speed) up on the y axis
    }
}
