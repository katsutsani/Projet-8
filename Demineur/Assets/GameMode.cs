using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public void Mode(int mode)
    {
        if(mode == 0)
        {
            // classique mode
            PlayerPrefs.SetInt("Mode", mode);
        }
        else if(mode == 1)
        {
            // contre la montre
            PlayerPrefs.SetInt("Mode", mode);
        }
    }
}
