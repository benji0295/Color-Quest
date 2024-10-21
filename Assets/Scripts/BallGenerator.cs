using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
  public GameObject redBall;
  public GameObject blueBall;
  public GameObject greenBall;
  public GameObject yellowBall;
  public float distanceFromGenerator = 5.0f;
  public float height = 0.1f;

  private void Start()
  {
    var redPosition = Random.Range(-distanceFromGenerator, distanceFromGenerator);
    var bluePosition = Random.Range(-distanceFromGenerator, distanceFromGenerator);
    var greenPosition = Random.Range(-distanceFromGenerator, distanceFromGenerator);
    var yellowPosition = Random.Range(-distanceFromGenerator, distanceFromGenerator);

    Instantiate(redBall, new Vector3(redPosition, height, redPosition), Quaternion.identity);
    Instantiate(blueBall, new Vector3(bluePosition, height, -bluePosition), Quaternion.identity);
    Instantiate(greenBall, new Vector3(-greenPosition, height, greenPosition), Quaternion.identity);
    Instantiate(yellowBall, new Vector3(-yellowPosition, height, -yellowPosition), Quaternion.identity);

  }

}
