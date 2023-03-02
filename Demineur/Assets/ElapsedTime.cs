using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElapsedTime : MonoBehaviour
{
    private TextMeshProUGUI t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TextMeshProUGUI>();
        t.enabled = false;
    }
    public void Enable()
    {
        t.enabled = true;
        t.text = "Temps écoulé";
    }
}
