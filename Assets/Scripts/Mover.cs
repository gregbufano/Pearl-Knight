using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb;
    public bool grounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoveRight(float speed)
    {
        rb.AddForce(tf.right * speed);
    }
    public void MoveLeft(float speed)
    {
        rb.AddForce(tf.right * -speed);
    }
    public void Jump(float jumpForce)
    {
        if (grounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Player is not grounded");
        }
    }
    public void Hit()
    {

    }
    // checking for grounded
    public void Checkgrounding()
    {
        

    }

}


