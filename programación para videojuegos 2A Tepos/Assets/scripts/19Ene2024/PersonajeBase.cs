using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PersonajeBase : MonoBehaviour
{
    public bool isDead = false;
    protected int health = 100;
    protected int age = 0;
    protected int strenght = 0;

    public float getHealth() 
    {
        return health;
    }

    public bool getIsDead()
    {
        return isDead;
    }

}