using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Héroe : PersonajeBase
{
    private Quest quest;

    public string name;
    public string description;
    public string tittle;

    public Quest GetQuest() 
    {
        return Quest;
    } 
    public void setQuest(string _name, string _description, string _tittle )
    {
        
    }

    
    void Update()
    {
        
    }
}
