using UnityEngine;
using UnityEngine.UI;

public class FillHealthBar : MonoBehaviour
{
    public Image healthBar;
    public Health health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealthBar()
    {
        // updates the health bar fill amount based on the current health
        if (healthBar != null && health != null)
        {
            float healthRatio = health.currentHealth / health.maxHealth;
            healthBar.fillAmount = healthRatio;
        }
        
    }
}
