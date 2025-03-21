using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;           
    public float spawnInterval = 0f;  
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        
        if (timer >= spawnInterval)
        {
           
            Instantiate(prefab, new Vector3(0, 10, 0), Quaternion.identity);

           
            timer = 0f;
        }
    }

}


