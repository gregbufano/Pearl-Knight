using Unity.Cinemachine;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    public PolygonCollider2D mapBoundry;
    public CinemachineConfiner2D confiner;
    public Direction direction;
    public float push; // The amount to push the player in the direction of the transition
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
        confiner = FindFirstObjectByType<CinemachineConfiner2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCameraBoundry(PolygonCollider2D newMapBoundry)
    {
        confiner.BoundingShape2D = newMapBoundry;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundry;
            UpdatePlayerPosition(collision.gameObject);
            confiner.InvalidateBoundingShapeCache();
        }
    }
    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 playerpos = player.transform.position;

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
