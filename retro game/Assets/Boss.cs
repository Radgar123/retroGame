using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private int maxLife;
    [SerializeField] private int currentLife;
    [SerializeField] private int speed;

    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
        healthBar.SetMaxHealth(maxLife);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
