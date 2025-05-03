using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsPageUI : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider SFX;
    public Slider Music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MusicVolumeChange();
        SFXVolumeChange();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // this function allows the sliders to change the volumes of the music and sfx
    public void MusicVolumeChange()
    {
        float newVolume = Music.value;

        if (newVolume<= 0.0f)
        {
            newVolume = -80.0f;
        }
        else
        {
           newVolume = Mathf.Log10(newVolume);

            newVolume = newVolume * 20.0f;

        }
        audioMixer.SetFloat("MusicVolume", newVolume);
    }
    // this function allows the sliders to change the volumes of the music and sfx
    public void SFXVolumeChange()
    {
        float newVolume = SFX.value;
        // if the volume is 0, set it to -80 to mute the sound

        if (newVolume <= 0.0f)
        {
            newVolume = -80.0f;
        }
        else
        {
            newVolume = Mathf.Log10(newVolume);

            newVolume = newVolume * 20.0f;

        }
        audioMixer.SetFloat("SFXVolume", newVolume);
    }
}

