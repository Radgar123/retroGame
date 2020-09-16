using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeaponTool : MonoBehaviour
{
    [SerializeField] private int x;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ChangeWeapon.Index = x;

            Destroy(gameObject);
        }
    }
}
