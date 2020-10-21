using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;
using UnityEngine.UI;

public class WorldController : MonoBehaviour
{
    [SerializeField] private GameObject nextWorld;
    [SerializeField] private int pointsToNextWorld;
    [SerializeField] private int minimumScore;

    // Start is called before the first frame update
    void Start()
    {
        minimumScore = PointController.scoreValue + pointsToNextWorld;
    }

    // Update is called once per frame
    void Update()
    {
        GetNextWorld();
    }

    void GetNextWorld() 
    {
        if (PointController.scoreValue >= minimumScore) 
        {
            nextWorld.SetActive(true);
        }
    }
}
