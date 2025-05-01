using JetBrains.Annotations;
using System.Xml.Serialization;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Mover mover;

    public float speed;

    public float verticleSpeed;

    public float jumpForce;

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode hit;

    public bool grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveLeft))
        {
            mover.MoveLeft(speed);
        }
        if (Input.GetKey(moveRight))
        {
            mover.MoveRight(speed);
        }
        if (Input.GetKey(moveUp))
            {
            mover.MoveUp(speed);
        }
        if (Input.GetKey(moveDown))
        {
            mover.MoveDown(speed);
        }
        if (Input.GetKeyDown(hit))
        {
            mover.Hit();
        }
    }

    
}
    // to check if player is grouned ( will need to program in later
    


