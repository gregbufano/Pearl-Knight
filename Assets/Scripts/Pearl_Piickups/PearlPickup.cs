using UnityEngine;

public class PearlPickup : MonoBehaviour
{
    public int ScoreIncreaseAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.IncreaseScore(ScoreIncreaseAmount);
        Debug.Log("Pearl collected! Score increased by " + ScoreIncreaseAmount);
        Destroy(gameObject);
    }
}
