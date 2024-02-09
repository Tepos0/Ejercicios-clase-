using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//La clase es un contendor de toda la logica de nuestro objeto
public class tema1 : MonoBehaviour
{
    // Variables globales
    //Variable: Es  un contenedor de información 

    public int edad = 25;
    void Start()
    {
        //Variables locales 
        int resultado = suma (5, 5);
        Debug.Log("El resultado es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void walk(/* parametros */)
    {

    }
    int suma(int x, int y)
    {
        return x + y;
    }
}
