using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cadenadeCaracteres : MonoBehaviour
{
    public string data = "x:2 , y:5 , x:8";
    public Vector3 position;
    void Start()
    {
        //1. Recorrer todo nuestro string = "x:2, y:5, z:8"
        for (int  i = 0; i < data.Length; i++)
        {
            //2.Revisaremos si el valor en el indice (data [1+2]) , es igual a x
          if (data[i] == "x")
            {

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
