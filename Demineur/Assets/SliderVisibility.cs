using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderVisibility : MonoBehaviour
{
    public GameObject slider;

    public void isButtonCliked()
    {
        if (slider.activeInHierarchy == true) 
        {
            slider.SetActive(false);
        }
        else
        {
            slider.SetActive(true);
        }
    }
}
