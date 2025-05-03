using UnityEngine;

public class CreditMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeToCreditMenu()
    {
        // goes into game manager and deactivates all states and then activates the credit menu
        GameManager.instance.DeactivateAllStates();
        GameManager.instance.creditMenu.SetActive(true);
    }
}
