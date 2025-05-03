using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UiManager uiManager;
    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject creditMenu;
    public GameObject gameplay;
    public GameObject startMenu;
    public GameObject settingPage;
    public string objectTag;
    public int chestCount;
    public int lives;


    public int score;
    public void Awake()
    {
        // makes sure there is only one game manager instance
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // when program starts, the game manager will be set to the main menu
        ActivateStartMenu();
        
    }

    void Update()
    {
    }

    public void IncreaseScore(int amount)
    {
        // increases the score by a certain amount when item is picked up
        score += amount;
        uiManager.UpdateText(" " + score);
    }

    

    public void DecreaseChestCount()
    {
        // decreases the chest count when a chest is picked up
        chestCount--;
        if (chestCount <= 0)
        {
            // when all chest are picked up, the player wins
            TriggerWin();
        }

    }
    // when the player dies they lost a life, when all lives are lost the player loses
    public void DecreaseLives()
    {
        lives--;
        if (lives <= 0)
        {
            TriggerLoss();
        }
    }
    void TriggerLoss()
    {
        Debug.Log("You Lose");
    }
    void TriggerWin()
    {
        Debug.Log("You Win");
    }
    

    public void DeactivateAllStates()
    {
        // deactivates all of the game objects in the function
        mainMenu.SetActive(false);
        settingMenu.SetActive(false);
        creditMenu.SetActive(false);
        gameplay.SetActive(false);
        startMenu.SetActive(false);
    }

    public void ActivateMainMenu()
    {
        // actuvates the main menu only
        DeactivateAllStates();
        mainMenu.SetActive(true);
    }

    public void ActivateSettingMenu()
    {
        // activates the settings only
        DeactivateAllStates();
        settingMenu.SetActive(true);
    }

    public void ActivateCreditMenu()
    {
        // activates the credit menu only
        DeactivateAllStates();
        creditMenu.SetActive(true);
    }

    public void ActivateGameplay()
    {
        // activates the gameplay only
        DeactivateAllStates();
        gameplay.SetActive(true);
        chestCount = 0;

        // Count all chests in the scene
        foreach (GameObject chest in GameObject.FindGameObjectsWithTag("Chest"))
        {
            chestCount++;
        }

        Debug.Log("Chest Count: " + chestCount);

    }

    public void ActivateStartMenu()
    {
        // activates the start menu only
        DeactivateAllStates();
        startMenu.SetActive(true);
    }

    public void SaveVolume()
    {
        // Ensure you have a reference to the SettingsPageUI instance
        SettingsPageUI settingsPageUI = Object.FindFirstObjectByType<SettingsPageUI>();
        if (settingsPageUI != null)
        {
            // Save the volume using the instance of SettingsPageUI
            PlayerPrefs.SetFloat("MusicVolume", settingsPageUI.Music.value);
            PlayerPrefs.SetFloat("SFXVolume", settingsPageUI.SFX.value);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.LogError("SettingsPageUI instance not found in the scene.");
        }
    }

    public void QuitGame()
    {
        // allows the user the quit the game even in editor.
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();  
#endif
    }
}
