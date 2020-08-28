using System.Collections;
using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
  private float horizontalInput = 0;
  private float verticalInput = 0;
  //public Rigidbody2D rb;


  [SerializeField] private float movementSpeed = 1;
  [SerializeField] private float rotationSpeed = 1;
  
  

  void Update()
  {
    GetPlayerInput();
    MovePlayer();
    RotatePlayer();
    //rb.AddForce(transform.right * movementSpeed);
  }

  private void GetPlayerInput()
  {
    horizontalInput = -Input.GetAxisRaw("Horizontal");
    verticalInput = Input.GetAxisRaw("Vertical");
  }
  private void MovePlayer()
  {
    transform.position +=
      transform.up * verticalInput * movementSpeed * Time.deltaTime;
  }
  private void RotatePlayer()
  {
    transform.Rotate(0,0, horizontalInput * rotationSpeed * Time.deltaTime);
  }

}
