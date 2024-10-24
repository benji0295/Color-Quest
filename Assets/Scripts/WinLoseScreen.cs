using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseScreen : MonoBehaviour
{
  private void Start()
  {

  }

  private void Update()
  {
    if (Input.anyKeyDown)
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("LevelOne");
    }
  }
}
