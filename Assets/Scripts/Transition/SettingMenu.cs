using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeToSettingMenu()
    {
        GameManager.instance.DeactivateAllStates();
        GameManager.instance.settingMenu.SetActive(true);
    }
}
