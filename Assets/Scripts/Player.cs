using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  public Animator animator;
  private bool walk = false;
  public GameObject go;


  void Start()
  {
    animator = GetComponent<Animator>();
  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
    {
      walk = !walk;
      animator.SetBool("isWalking", walk);
    }
    
  }
  //void OnCollisionEnter(Collision collision)
  //{
  //    if (collision.gameObject.tag == "Brick")
  //    {
  //        Destroy(collision.gameObject);
  //    }
  //}
}
