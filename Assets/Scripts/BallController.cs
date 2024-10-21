using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

  private bool isRedComplete = false;
  private bool isBlueComplete = false;
  private bool isGreenComplete = false;
  private bool isYellowComplete = false;
  private void Update()
  {
    if (isRedComplete && isBlueComplete && isGreenComplete && isYellowComplete)
    {
      Debug.Log("Game Over.");
    }
  }
  private void OnTriggerEnter(Collider other)
  {
    if (gameObject.CompareTag("RedBall") && other.CompareTag("RedCorner"))
    {
      Debug.Log("Red complete.");
      isRedComplete = true;
    }
    else if (gameObject.CompareTag("BlueBall") && other.CompareTag("BlueCorner"))
    {
      Debug.Log("Blue complete.");
      isBlueComplete = true;
    }
    else if (gameObject.CompareTag("GreenBall") && other.CompareTag("GreenCorner"))
    {
      Debug.Log("Green complete.");
      isGreenComplete = true;
    }
    else if (gameObject.CompareTag("YellowBall") && other.CompareTag("YellowCorner"))
    {
      Debug.Log("Yellow complete.");
      isYellowComplete = true;
    }
    else
    {
      Debug.Log("Wrong corner.");
    }
  }
}
