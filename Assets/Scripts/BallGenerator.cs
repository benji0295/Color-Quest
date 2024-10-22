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
  public float minDistanceFromGenerator = 3.0f;
  public float height = 24.0f;

  private void Start()
  {
    var redPosition = Random.Range(minDistanceFromGenerator, maxDistanceFromGenerator);
    var yellowPosition = Random.Range(minDistanceFromGenerator, maxDistanceFromGenerator);
    var greenPosition = Random.Range(minDistanceFromGenerator, maxDistanceFromGenerator);
    var bluePosition = Random.Range(minDistanceFromGenerator, maxDistanceFromGenerator);

    Instantiate(redBall, new Vector3(redPosition, height, redPosition), Quaternion.identity);
    Instantiate(blueBall, new Vector3(-bluePosition, height, bluePosition), Quaternion.identity);
    Instantiate(greenBall, new Vector3(-greenPosition, height, -greenPosition), Quaternion.identity);
    Instantiate(yellowBall, new Vector3(yellowPosition, height, -yellowPosition), Quaternion.identity);

  }

}
