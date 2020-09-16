using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    private float angle;

    [SerializeField] private int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 eu = transform.eulerAngles;
        eu.z = Random.Range(0f, 360f);
        transform.eulerAngles = eu;
        angle = Random.Range(-45f, 45f);

    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, angle) * speed *  Time.deltaTime);
    }

}
