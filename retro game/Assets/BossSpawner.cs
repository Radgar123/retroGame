using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [Header("World Index")]
    [SerializeField] private int index1;
    [SerializeField] private Transform[] spawnSpots;

    [Header("World1")]
    [SerializeField] private GameObject[] bossOnWorld1;
    [SerializeField] private int points1;
    [SerializeField] private bool boos1;

    [Header("World2")]
    [SerializeField] private GameObject[] bossOnWorld2;
    [SerializeField] private int points2;
    [SerializeField] private bool boos2;

    [Header("World3")]
    [SerializeField] private GameObject[] bossOnWorld3;
    [SerializeField] private int points3;
    [SerializeField] private bool boos3;

    [Header("World4")]
    [SerializeField] private GameObject[] bossOnWorld4;
    [SerializeField] private int points4;
    [SerializeField] private bool boos4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BosSpawner() 
    {
        if (index1 == 1) 
        {
            int randBoss = Random.Range(0, bossOnWorld1.Length);
            int randPos = Random.Range(0, spawnSpots.Length);


            if (PointController.scoreValue >= points1 && boos1)
            {
                Instantiate(bossOnWorld1[randBoss], spawnSpots[randPos].position, Quaternion.identity);
                boos1 = false;
            }
        }
        else
        {
            int randBoss = Random.Range(0, bossOnWorld1.Length);
            int randPos = Random.Range(0, spawnSpots.Length);


            if (PointController.scoreValue >= points1 && boos1)
            {
                Instantiate(bossOnWorld1[randBoss], spawnSpots[randPos].position, Quaternion.identity);
                boos1 = false;
            }
        }
    }

}
