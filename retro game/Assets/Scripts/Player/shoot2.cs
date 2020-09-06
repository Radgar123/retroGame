using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    private bool canShoot = true;
    [SerializeField] private GameObject bullet1 = null;
    [SerializeField] private GameObject bullet2 = null;
    [SerializeField] private AudioSource audio;
    [SerializeField] private float shootDelay = .5f;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

 

    void Fire() 
    {
        if(Input.GetButton("Fire1") && canShoot) 
        {
            audio.Play();
            canShoot = false;
            Instantiate(bullet1, transform.position, transform.rotation);
            Instantiate(bullet2, transform.position, transform.rotation);
            StartCoroutine(ShootDelay(shootDelay));
        }
    }

    IEnumerator ShootDelay(float shootDelay) 
    {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }
}
