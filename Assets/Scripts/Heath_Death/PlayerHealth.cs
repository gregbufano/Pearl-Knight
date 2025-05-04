
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
        audioSource = GetComponent<AudioSource>();
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
            GameManager.instance.DecreaseLives();
            deathComponent.Die();
        }

    }
    protected override void OnTakeDamage(float amount)
    {
        Debug.Log("Player took damage: " + amount);
        
        
            audioSource.PlayOneShot(audioSource.clip);
        
        
    }
}
