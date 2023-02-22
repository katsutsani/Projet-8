using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int height;
    [SerializeField] private int Length;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        for (float i = -height/2; i < height/2; i++)
        {
            for (float j = -Length/2 ; j < Length/2; j++){
                Instantiate(prefab, new Vector2(j, i), Quaternion.identity);
                j+=0.2f;
            }
            i+=0.2f;

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            flag(); 
        }
        else if (Input.GetMouseButtonDown(0))
        {
            RemoveTile();
        }
    }

    private void flag()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(prefab2, new Vector2(worldPosition.x,worldPosition.y), Quaternion.identity);
    }

    private void RemoveTile()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(prefab2, new Vector2(worldPosition.x, worldPosition.y), Quaternion.identity);
    }

    private bool isATile(int x,int y)
    {
        //if ()
        //{

        //}
        return false;
    }
}
