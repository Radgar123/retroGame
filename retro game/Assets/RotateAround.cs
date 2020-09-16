using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] public GameObject target;
    [SerializeField] public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector2.up, 20 * speed * Time.deltaTime);
    }
}
