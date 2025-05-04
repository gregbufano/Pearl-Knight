using UnityEngine;

public class PressAnyKey : MonoBehaviour
{
    private bool hasPressedKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasPressedKey && Input.anyKeyDown)
        {
            // If any key is pressed, set the flag to true
            hasPressedKey = true;
            // Call the method to handle the key press
            GoToMenu();
        }
    }
    public void GoToMenu()
    {
        // Load the main menu scene
        GameManager.instance.DeactivateAllStates();
        GameManager.instance.mainMenu.SetActive(true); ;
    }
}
