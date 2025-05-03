using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;



public class Mover : MonoBehaviour
{
    private Transform tf;
    private Rigidbody2D rb;
    private Vector2 input;
    private Animator animator;
    private bool isMoving;

    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        isMoving = false;

        // Example input handling — update `input` here
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        // Call movement functions based on input
        if (input.x > 0) MoveRight(1f);
        else if (input.x < 0) MoveLeft(1f);
        else if (input.y > 0) MoveUp(1f);
        else if (input.y < 0) MoveDown(1f);

        // If no movement was triggered this frame, switch to idle animation
        if (!isMoving)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("InputX", input.x);
            animator.SetFloat("InputY", input.y);
        }
    }

    public void MoveRight(float speed)
    {
        isMoving = true;
        tf.position += tf.right * speed * Time.deltaTime;
        animator.SetBool("isWalking", true);
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }

    public void MoveLeft(float speed)
    {
        isMoving = true;
        tf.position += tf.right * -speed * Time.deltaTime;
        animator.SetBool("isWalking", true);
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }

    public void MoveUp(float verticalSpeed)
    {
        isMoving = true;
        tf.position += tf.up * verticalSpeed * Time.deltaTime;
        animator.SetBool("isWalking", true);
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }

    public void MoveDown(float verticalSpeed)
    {
        isMoving = true;
        tf.position += tf.up * -verticalSpeed * Time.deltaTime;
        animator.SetBool("isWalking", true);
        animator.SetFloat("InputX", input.x);
        animator.SetFloat("InputY", input.y);
    }

    public void Hit()
    {
        // Custom hit logic
    }
}



