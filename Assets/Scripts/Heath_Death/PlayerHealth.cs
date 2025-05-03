
using UnityEngine;

public class PlayerHealth : Health
{
   
    
    public AudioSource audioSource;
    private Death deathComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        deathComponent = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    protected override void Die()
    {
        Debug.Log("Player has died.");
        if (deathComponent != null)
        {
            deathComponent.Die();
        }

    }
    protected override void OnTakeDamage(float amount)
    {
        Debug.Log("Player took damage: " + amount);
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
        else
        {
            Debug.LogWarning("AudioSource or clip is not assigned.");
        }
    }
}
