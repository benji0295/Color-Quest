using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  private bool isRedComplete = false;
  private bool isBlueComplete = false;
  private bool isGreenComplete = false;
  private bool isYellowComplete = false;
  private AudioSource audioSource;

  public AudioClip achievementSound;

  private void Start()
  {
    audioSource = GetComponent<AudioSource>();
  }

  private void Update()
  {
    if (isRedComplete && isBlueComplete && isGreenComplete && isYellowComplete)
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("WinScreen");
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (gameObject.CompareTag("RedBall") && other.CompareTag("RedCorner"))
    {
      Debug.Log("Red complete.");
      audioSource.PlayOneShot(achievementSound);
      isRedComplete = true;
    }
    else if (gameObject.CompareTag("BlueBall") && other.CompareTag("BlueCorner"))
    {
      Debug.Log("Blue complete.");
      audioSource.PlayOneShot(achievementSound);
      isBlueComplete = true;
    }
    else if (gameObject.CompareTag("GreenBall") && other.CompareTag("GreenCorner"))
    {
      Debug.Log("Green complete.");
      audioSource.PlayOneShot(achievementSound);
      isGreenComplete = true;
    }
    else if (gameObject.CompareTag("YellowBall") && other.CompareTag("YellowCorner"))
    {
      Debug.Log("Yellow complete.");
      audioSource.PlayOneShot(achievementSound);
      isYellowComplete = true;
    }
  }
}
