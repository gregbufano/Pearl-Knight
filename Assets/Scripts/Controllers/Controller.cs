using JetBrains.Annotations;
using System.Xml.Serialization;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Mover mover;

    [SerializeField] float speed;

    public float verticleSpeed;

    public float jumpForce;
    // allows the designers to designate the keys in the inspector
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
        // checks if the player has pressed the designated keys
        if (Input.GetKey(moveLeft))
        {
            // uses the mover class to define the movement of the player
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
    


