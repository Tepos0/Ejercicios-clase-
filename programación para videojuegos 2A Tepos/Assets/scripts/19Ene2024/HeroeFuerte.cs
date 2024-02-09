using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HeroeFuerte : PersonajeBase 
{
    public float hability = 30f;

    public float getHability()
    {
        if (getQuest().id == 2)
        {
            return hability - 2f;
        }
        return hability;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
