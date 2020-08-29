using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeySpawner : MonoBehaviour
{
      [SerializeField] private GameObject[] enemy;               
      [SerializeField] private  float spawnTime = 3f;   

      [SerializeField] private Transform[] spawnPoints;         


      void Start ()
      {
          InvokeRepeating ("Spawn", spawnTime, spawnTime);
      }

      void Spawn ()
      {
          int enemyIndex = Random.Range(0, enemy.Length);
          int spawnPointIndex = Random.Range (0, spawnPoints.Length);
          Instantiate (enemy[enemyIndex] , spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
      }
}
