using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    [SerializeField] private GameObject[] weaponArsenal;

    public static int Index = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponArsenal[Index - 1]) 
        {
            for (int i = 0; i < weaponArsenal.Length; i++)
            {
                if (i == Index - 1)
                {
                    weaponArsenal[Index - 1].SetActive(true);
                }
                else
                    weaponArsenal[i].SetActive(false);
            }
        }
    }

}
