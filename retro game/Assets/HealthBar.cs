using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider bossLife;

    public void SetMaxHealth(int health) 
    {
        bossLife.maxValue = health;
        bossLife.value = health;
    }

    public void SetHealth(int health)
    {
        bossLife.value = health;
    }
}
