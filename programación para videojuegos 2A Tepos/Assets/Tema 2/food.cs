using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public int spawnLimit = 10;
    public int spawnCount = 0;
    public GameObject prefab;
    void Start()
    {
        while (spawnCount <= 20)
        {
            Instantiate(prefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
            spawnCount++;
                                         
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
