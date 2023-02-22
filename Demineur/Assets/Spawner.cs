using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -10; i < 10; i++)
        {
            Instantiate(prefab, new Vector2(i, 1), Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
