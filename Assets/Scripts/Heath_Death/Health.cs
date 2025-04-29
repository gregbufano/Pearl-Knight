using UnityEngine;

public class Health : MonoBehaviour
{

    public float currentHealth;
    public float maxHealth;

    public Death deathComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathComponent = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Heal(float amount)
    {
        currentHealth = currentHealth + amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

       // Later intergrate Health Bard
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Triggereing Death");
            deathComponent.Die();
        }
    }
}
