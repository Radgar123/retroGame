using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private bool canShoot = true;
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private AudioSource audio;
    [SerializeField] private float shootDelay = .5f;



    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Input.GetButton("Fire1") && canShoot)
        {
            audio.Play();
            canShoot = false;
            Instantiate(bullet, transform.position, transform.rotation);
            StartCoroutine(ShootDelay(shootDelay));
        }
    }

    IEnumerator ShootDelay(float shootDelay)
    {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }
}
