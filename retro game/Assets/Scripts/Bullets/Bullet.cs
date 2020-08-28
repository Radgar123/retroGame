using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
  [SerializeField] private float bulletSpeed = 1;
  [Range(1, 10)] [SerializeField] private int liveTime = 1;

  void Start()
  {
    GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    StartCoroutine(LiveTime(liveTime));
  }

  IEnumerator LiveTime(int time)
  {
    yield return new WaitForSeconds(time);
    Destroy(gameObject);
  }
}
