using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    public int value;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            PointController.scoreValue += value;
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
        }
    }
}
