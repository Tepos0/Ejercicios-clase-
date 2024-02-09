using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
   protected string Name = "Enemy";
    protected int Health = 100;
    protected List <string> loot;
    


    public virtual void Init()
    {
        loot = new List <string> ();    
    }
    public virtual void Addloot(string item)
    {
      loot.Add(item);   
    }

    public virtual List <string> GetLoot()
    {
        return loot;
    }
    public virtual int GetHealth()
    {
        return Health;
    }
}
