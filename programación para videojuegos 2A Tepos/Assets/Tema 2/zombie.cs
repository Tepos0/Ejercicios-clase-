using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : enemigo
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
        Addloot("Pala");
        Addloot("Casco");
        Addloot("zanahoria");
        Addloot("lingote de oro");

        Debug.Log("Loot:");

        for (int i = 0; i < GetLoot().Count; i++)
        {
            Debug.Log(GetLoot()[i]);
        }
    }

    void Update()
    {
        
    }
}
