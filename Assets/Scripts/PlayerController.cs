using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private const float DEFAULT_TIME_LIMIT = 60.0f;

  private Rigidbody rb;

  public float speed = 200.0f;
  public TMP_Text timeText;
  public float timeLimit;
  public BallController redBallController;
  public BallController blueBallController;
  public BallController greenBallController;
  public BallController yellowBallController;

  private Vector3 startingSize;
  private Vector3 movementInput;
  private float startingSpeed;

  private void Start()
  {
    rb = GetComponent<Rigidbody>();

    startingSize = transform.localScale;
    startingSpeed = speed;
  }

  private void Update()
  {

    timeLimit -= Time.deltaTime;
    timeText.text = "Time: " + timeLimit.ToString("F2");

    if (timeLimit <= 0)
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("LoseScreen");
      timeLimit = DEFAULT_TIME_LIMIT;
    }


    float horizontal = 0;
    float vertical = 0;

    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
    {
      vertical = 1;
    }
    else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
    {
      vertical = -1;
    }

    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
      horizontal = -1;
    }
    else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
      horizontal = 1;
    }

    movementInput = new Vector3(horizontal, 0, vertical).normalized * speed;
  }

  private void FixedUpdate()
  {
    rb.AddForce(movementInput, ForceMode.Force);
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
