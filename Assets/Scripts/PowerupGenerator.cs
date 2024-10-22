using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGenerator : MonoBehaviour
{
  public List<GameObject> powerups;
  public float distanceFromGenerator = 10.0f;
  public float spawn = 5.0f;
  public float duration = 5.0f;

  private float timer;
  private GameObject currentPowerup;

  private void Start()
  {
    timer = spawn;
  }

  private void Update()
  {
    timer -= Time.deltaTime;

    if (timer <= 0)
    {
      if (currentPowerup == null)
      {
        var randomPowerup = Random.Range(0, powerups.Count);
        currentPowerup = Instantiate(powerups[randomPowerup], new Vector3(Random.Range(-distanceFromGenerator, distanceFromGenerator), 24.0f, Random.Range(-distanceFromGenerator, distanceFromGenerator)), Quaternion.identity);
        timer = duration;
      }
      else
      {
        Destroy(currentPowerup);
        timer = spawn;
      }
    }
  }
}
