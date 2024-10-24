using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private const float DEFAULT_TIME_LIMIT = 60.0f;

  private Rigidbody ridigbody;

  public float speed = 2.0f;
  public TMP_Text timeText;
  public float timeLimit;

  private Vector3 startingSize;
  private float startingSpeed;

  private void Start()
  {
    ridigbody = GetComponent<Rigidbody>();

    startingSize = transform.localScale;
    startingSpeed = speed;

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
      UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScreen");
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
  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Grow"))
    {
      speed = startingSpeed;

      transform.localScale += new Vector3(1, 1, 1);
      Destroy(other.gameObject);
    }
    else if (other.CompareTag("Shrink"))
    {
      speed = startingSpeed;

      if (transform.localScale.x > startingSize.x * 0.5f)
      {
        transform.localScale -= new Vector3(1, 1, 1);
      }
      Destroy(other.gameObject);
    }
    else if (other.CompareTag("Fast"))
    {
      transform.localScale = startingSize;

      speed += 0.5f;
      Destroy(other.gameObject);
    }
    else if (other.CompareTag("Slow"))
    {
      transform.localScale = startingSize;

      speed -= 0.5f;
      Destroy(other.gameObject);
    }
  }
}
