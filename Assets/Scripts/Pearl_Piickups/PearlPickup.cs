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
    // this code is used to check if the player collected the chest 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // increases the score by the amount of score increase
        GameManager.instance.IncreaseScore(ScoreIncreaseAmount);
        Debug.Log("Pearl collected! Score increased by " + ScoreIncreaseAmount);
        // decreases the chest count by 1 to keep track of how many chests are left until 
        // the player wins
        GameManager.instance.DecreaseChestCount();
        // destroys the pearl object after it is collected
        Destroy(gameObject);
    }
}
