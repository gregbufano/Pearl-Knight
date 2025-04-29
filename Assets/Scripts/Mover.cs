using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb;
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
        rb.AddForce(tf.right * speed * Time.deltaTime);
    }
    public void MoveLeft(float speed)
    {
        rb.AddForce(tf.right * -speed * Time.deltaTime);
    }
    public void Jump(float jumpForce)
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    public void Hit()
    {

    }
}


