using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private  float spawnTime = 3f;

    [SerializeField] private float min;
    [SerializeField] private float max;
    

              


     void Start ()
     {
         InvokeRepeating ("Spawn", spawnTime, spawnTime);
     }

    private void Update()
    {
        RandomSpawnTime();
    }

    void Spawn ()
      {
          int enemyIndex = Random.Range(0, enemy.Length);
          int spawnPointIndex = Random.Range (0, spawnPoints.Length);
          Instantiate (enemy[enemyIndex] , spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
      }

    void RandomSpawnTime() 
    {
        spawnTime = Random.Range(min, max);
    }
}
