using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public bool isComplete = false;
  private AudioSource audioSource;
  private int totalBalls = 4;
  private static int ballsCompleted = 0;

  public AudioClip achievementSound;

  private void Start()
  {
    audioSource = GetComponent<AudioSource>();
  }

  private void Update()
  {
    if (ballsCompleted == totalBalls)
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("WinScreen");
      ballsCompleted = 0;
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (!isComplete)
    {
      if (gameObject.CompareTag("RedBall") && other.CompareTag("RedCorner"))
      {
        Debug.Log("Red complete.");
        audioSource.PlayOneShot(achievementSound);
        isComplete = true;
        ballsCompleted++;
        Debug.Log($"Completed Ball Count: {ballsCompleted}");
      }
      else if (gameObject.CompareTag("BlueBall") && other.CompareTag("BlueCorner"))
      {
        Debug.Log("Blue complete.");
        audioSource.PlayOneShot(achievementSound);
        isComplete = true;
        ballsCompleted++;
        Debug.Log($"Completed Ball Count: {ballsCompleted}");
      }
      else if (gameObject.CompareTag("GreenBall") && other.CompareTag("GreenCorner"))
      {
        Debug.Log("Green complete.");
        audioSource.PlayOneShot(achievementSound);
        isComplete = true;
        ballsCompleted++;
        Debug.Log($"Completed Ball Count: {ballsCompleted}");
      }
      else if (gameObject.CompareTag("YellowBall") && other.CompareTag("YellowCorner"))
      {
        Debug.Log("Yellow complete.");
        audioSource.PlayOneShot(achievementSound);
        isComplete = true;
        ballsCompleted++;
        Debug.Log($"Completed Ball Count: {ballsCompleted}");
      }
    }
  }
}
