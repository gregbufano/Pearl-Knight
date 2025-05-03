using UnityEngine;

// Ensure the UpdateHealthbar class is defined or imported
// If this class exists in your project but is in a different namespace, add the appropriate using directive.
// Example: using YourNamespace;



public abstract class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public UpdateHealthbar healthBarFiller;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void Heal(float amount)
    {
        // does the math to check if the player healed and limits the health to the max health
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        // changes the fill amount of the health bar
        if (healthBarFiller != null)
        {
            healthBarFiller.ChangeFillAmount();
        }
    }

    public virtual void TakeDamage(float amount)
    {
        // calculates the damage the player took and limits the health to 0
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthBarFiller != null)
        {
            healthBarFiller.ChangeFillAmount();
        }

        if (currentHealth <= 0)
        {
            Die(); // Call the abstract death logic
        }
    }

    // Must be implemented by child class
    protected abstract void Die();

    protected abstract void OnTakeDamage(float amount);
}

