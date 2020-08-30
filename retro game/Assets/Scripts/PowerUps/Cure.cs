using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.forward * 50 * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lifeCounter.heart += 1;
            Destroy(gameObject);
        }
    }
}
