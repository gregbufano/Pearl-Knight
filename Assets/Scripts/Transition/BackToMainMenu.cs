using UnityEngine;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButton()
    {
        GameManager.instance.DeactivateAllStates();
        GameManager.instance.mainMenu.SetActive(true);
    }
}
