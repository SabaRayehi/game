using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessLevel : MonoBehaviour
{
    public GameObject block ;
    public int num = 300;
    public float minX = 2f;
    public float maxX = -2f;
    public float minY = .3f;
    public float maxY = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 VPosition = new Vector3();

        for (int i = 0; i < num; i++)
        {
            VPosition.y += GetRandomPrefabInitialX();

            VPosition.x = GetRandomPrefabInitialY();
            Instantiate(block, VPosition, Quaternion.identity);
        }

    }


   
    float GetRandomPrefabInitialX()
    {
        return UnityEngine.Random.Range(minX, maxX);
    }
    float GetRandomPrefabInitialY()
    {
        return UnityEngine.Random.Range(minY, maxY);
    }
}

