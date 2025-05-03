using UnityEngine;

public class SpikeDMG : MonoBehaviour
{
    public float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // This function is called when the player enters the trigger collider of the spike they take 
    // damage
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Health health = collision.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("Player took damage from spike!");
            }
            else
            {
                Debug.Log("No Health component found on player.");
            }
        }
    }
}

