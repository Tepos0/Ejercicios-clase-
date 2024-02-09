using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : Herencia
{
    void start 
    {
        Ataque = 6;
        Durabilidad = 20;
        Rareza = común , raro , infrecuente;
        Efecto = fuego , hielo , rayo;
    }
    private void OncollisionEnter(Collision collision)
    {
        if (collision.CompareTag("Enemigo")
        {
            AtaqueTotal = MobLife - Ataque;
            Debug.Log("Ataque exitoso");
        }
        else
        {
            return;
        }
    }
 
}


