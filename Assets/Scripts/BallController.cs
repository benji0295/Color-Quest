using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

  private void Start()
  {

  }
  private void OnTriggerEnter(Collider other)
  {
    if (gameObject.CompareTag("RedBall") && other.CompareTag("RedCorner"))
    {
      Debug.Log("Red complete.");
    }
    else if (gameObject.CompareTag("BlueBall") && other.CompareTag("BlueCorner"))
    {
      Debug.Log("Blue complete.");
    }
    else if (gameObject.CompareTag("GreenBall") && other.CompareTag("GreenCorner"))
    {
      Debug.Log("Green complete.");
    }
    else if (gameObject.CompareTag("YellowBall") && other.CompareTag("YellowCorner"))
    {
      Debug.Log("Yellow complete.");
    }
    else
    {
      Debug.Log("Wrong corner.");
    }

  }
}
