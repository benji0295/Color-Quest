using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody ridigbody;

  public float speed = 2.0f;

  private void Start()
  {
    ridigbody = GetComponent<Rigidbody>();
  }


  private void Update()
  {
    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
    {
      ridigbody.AddForce(Vector3.forward * speed);
    }
    else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
    {
      ridigbody.AddForce(Vector3.forward * -speed);
    }
    else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
      ridigbody.AddForce(Vector3.right * -speed);
    }
    else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
      ridigbody.AddForce(Vector3.right * speed);
    }
  }
}
