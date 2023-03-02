using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Difficulty : MonoBehaviour
{
    // Start is called before the first frame update
    public void Easy()
    {
        PlayerPrefs.SetString("Difficulty","Easy");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Medium()
    {
        PlayerPrefs.SetString("Difficulty", "Medium");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Hard()
    {
        PlayerPrefs.SetString("Difficulty", "Hard");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GoBack()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
