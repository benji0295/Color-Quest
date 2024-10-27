using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
  public GameObject redBall;
  public GameObject blueBall;
  public GameObject greenBall;
  public GameObject yellowBall;
  public float maxDistanceFromGenerator = 10.0f;
  public float minDistanceFromGenerator = 5.0f;
  public float height = 24.0f;

  private void Start()
  {
    var redPosition = RandomPosition();
    var yellowPosition = RandomPosition();
    var greenPosition = RandomPosition();
    var bluePosition = RandomPosition();

    Instantiate(redBall, redPosition, Quaternion.identity);
    Instantiate(yellowBall, yellowPosition, Quaternion.identity);
    Instantiate(greenBall, greenPosition, Quaternion.identity);
    Instantiate(blueBall, bluePosition, Quaternion.identity);

  }
  private Vector3 RandomPosition()
  {
    Vector2 direction = Random.insideUnitCircle.normalized;
    float distance = Random.Range(minDistanceFromGenerator, maxDistanceFromGenerator);
    Vector3 position = new Vector3(direction.x * distance, height, direction.y * distance);

    return position;
  }
}
