using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetInt("Mode", 0);
    }
    public void Mode(int mode)
    {
        PlayerPrefs.SetInt("Mode", mode);
    }
}