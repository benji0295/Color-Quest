using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private const float DEFAULT_TIME_LIMIT = 60.0f;

  private Rigidbody ridigbody;

  public float speed = 2.0f;
  public TMP_Text timeText;
  public double timeLimit;

  private void Start()
  {
    ridigbody = GetComponent<Rigidbody>();

    if (timeLimit <= 0)
    {
      timeLimit = DEFAULT_TIME_LIMIT;
    }
  }


  private void Update()
  {
    timeLimit -= Time.deltaTime;
    timeText.text = "Time: " + timeLimit.ToString("F2");

    if (timeLimit <= 0)
    {
      Debug.Log("Game Over.");
    }

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
