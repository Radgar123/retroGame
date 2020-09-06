using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    [SerializeField] public TimeManager timeManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            timeManager.SlowMotion();
            GameObject.Destroy(gameObject);
        }
            
    }
}
