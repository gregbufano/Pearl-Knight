using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb;
    private Vector2 input;


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
        //rb.AddForce(tf.right * speed);
        tf.position += tf.right * speed * Time.deltaTime;
    }
    public void MoveLeft(float speed)
    {
        //rb.AddForce(tf.right * -speed);
        tf.position += tf.right * -speed * Time.deltaTime;
    }
    public void MoveUp(float verticleSpeed)
    {
       // rb.AddForce(tf.up * verticleSpeed);
       tf.position += tf.up * verticleSpeed * Time.deltaTime;
    }
    public void MoveDown(float verticleSpeed)
    {
       // rb.AddForce(tf.up * -verticleSpeed);
       tf.position += tf.up * -verticleSpeed * Time.deltaTime;

    }
    
    public void Hit()
    {

    }
    

    

}


