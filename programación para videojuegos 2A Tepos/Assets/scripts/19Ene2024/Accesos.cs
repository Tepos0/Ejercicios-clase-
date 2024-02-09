using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accesos : MonoBehaviour
{
 public class HeroeFuerte : Héroe { }
 public class hechicero : EnemigoBase { }
 public class EnemigoBase : enemigo { }
  
    void Start()
    {
        HeroeFuerte = new HeroeFuerte();
        hechicero = new hechicero();

        HeroeFuerte.setQuest("Quest 1", "El uso de atributos en clases", "Clasificacion de atributos , el gran desafio");
        
        if (!heroeFuerte.isDead && !hechicero.isDead)
        {
            if (HeroeFuerte.getHealth() >= 51)
            {
                float combatResult = HeroeFuerte.getHability() - hechicero.getDamage();
                Debug.Log("El resultado deel combate es:" + combatResult);
            }
            else
            {
                Debug.Log("El heroetiene muy poca vida, regresa a la base. Vida" + HeroeFuerte.get.Health());
            }
        }
    }
    
    
}


