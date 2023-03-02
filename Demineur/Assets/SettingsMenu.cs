using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    Resolution[] resolutions;

   public void ResolutionsSettings()
    {
        resolutions = Screen.resolutions;
    }
   
   public void SetVolume(float volume)
    {
        Debug.Log(volume);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void FullScreeen()
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;
    }

}
