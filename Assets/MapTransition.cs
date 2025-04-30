using Unity.Cinemachine;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    public PolygonCollider2D mapBoundry;
    public CinemachineConfiner2D confiner;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundry;
        }
    }
}
