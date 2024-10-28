using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScreen : MonoBehaviour
{
  // Start is called before the first frame update
  private void Start()
  {

  }

  // Update is called once per frame
  private void Update()
  {
    if (Input.anyKeyDown)
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
  }
}
