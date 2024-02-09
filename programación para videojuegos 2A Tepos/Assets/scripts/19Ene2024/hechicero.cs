using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hechicero : EnemigoBase
{
    private int powerUp = Random.Range(10, 450);
    public int getPowerUp()
    {
        return  damage + powerUp; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
