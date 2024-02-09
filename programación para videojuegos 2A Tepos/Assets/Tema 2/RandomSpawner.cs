using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [Header("Configuration")]
    public List<GameObject> Prefabs;
    public float TimeBetweenSpawns = 3f;
    public float SpawnArea = 5f;

    [Header("Debug")]
    public Vector3 SpawnerPosition;
    public Color color;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void InstantiateRandomObject ()
    {
        //1.Generar una posicion aleatoria dentro del area 
        Vector3 RandomPosition = Random.insideUnitCircle * SpawnArea;
        RandomPosition.z = 0f;

        //2. Instancia el objeto en la posicion generada
        GameObject RandomObj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject NewObj = Instantiate(RandomObj, SpawnerPosition +  RandomPosition, Quaternion.identity);

        //3.Asignar un color aleatorio al material del sprite 
        SpriteRenderer spriteRenderer = NewObj.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color (Random.value , Random.value, Random.value);
        }
        NewObj.transform.parent = transform;

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, SpawnArea);
    }

}
