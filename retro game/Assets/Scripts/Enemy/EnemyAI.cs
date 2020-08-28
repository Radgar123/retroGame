using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform Player;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float speed;

    [SerializeField] private Vector2 movement;


    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direct = Player.position - transform.position;
        float objectAngle = Mathf.Atan2(direct.y, direct.x) * Mathf.Rad2Deg;

        rb.rotation = objectAngle;

        direct.Normalize();
        movement = direct;
    }

    void FixedUpdate() 
    {
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direct) 
    {
        rb.MovePosition((Vector2)transform.position + (direct * speed * Time.deltaTime));
    }


}
