using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    [SerializeField] private float speed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += new Vector3(speed, 0);
        }

    }
}
