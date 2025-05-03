using Unity.Cinemachine;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    public PolygonCollider2D mapBoundry;
    public CinemachineConfiner2D confiner;
    public Direction direction;
    public float push; // The amount to push the player in the direction of the transition
    // allows us to customize which direction the player is moving when entering the collision
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Awake()
    {
        // finds the CinemachineConfiner2D component in the scene
        confiner = FindFirstObjectByType<CinemachineConfiner2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCameraBoundry(PolygonCollider2D newMapBoundry)
    {
        // updates the camera boundry to the new map boundry
        confiner.BoundingShape2D = newMapBoundry;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // checks if the object that entered the trigger is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // When the player goes through the trigger, it updates the camera boundry to the new map boundry
            confiner.BoundingShape2D = mapBoundry;
            UpdatePlayerPosition(collision.gameObject);
            // invalidates the bounding shape cache to update the camera boundry when changing
            // boundaries
            confiner.InvalidateBoundingShapeCache();
        }
    }
    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 playerpos = player.transform.position;
        // pushes the player in the direction of the transformation
        switch (direction)
        {
            case Direction.Up:
                playerpos.y += push;
                break;
            case Direction.Down:
                playerpos.y -= push;
                break;
            case Direction.Left:
                playerpos.x -= push;
                break;
            case Direction.Right:
                playerpos.x += push;
                break;
        }
        player.transform.position = playerpos;
    }

}
