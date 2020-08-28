using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
  public void OnCollisionEnter2D(Collision2D collision)
  {
      if (collision.gameObject.tag == "enemy")
      {
          Destroy(gameObject);

      }

      if (collision.gameObject.tag == "wall")
      {
          Destroy(gameObject);
      }

      if (collision.gameObject.tag == "bullet")
      {
          Destroy(gameObject);

      }

  }
}
