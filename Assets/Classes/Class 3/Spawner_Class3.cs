using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Class3 : MonoBehaviour
{
  public GameObject pickupPrefab;
  public int spawnAmount = 10;
  public Camera mainCamera;

  public int rowAmount;
  public int columnAmount;
  public int circlePoints;

  public Transform originOfCircle;
  public float circleRadius;


  // Start is called before the first frame update
  void Start()
  {

    Vector3 topRightPixel = new Vector3(Screen.width, Screen.height, 0);
    Vector3 bottomLeftPixel = new Vector3(0, 0, 0);

    Vector3 topRightPosition = mainCamera.ScreenToWorldPoint(topRightPixel);
    Vector3 bottomLeftPosition = mainCamera.ScreenToWorldPoint(bottomLeftPixel);

    // generate pickups randomly
    for (int i = 0; i < spawnAmount; i++)
    {
      // code to repeat

      float randomXPos = Random.Range(bottomLeftPosition.x, topRightPosition.x);
      float randomYPos = Random.Range(bottomLeftPosition.y, topRightPosition.y);
      Vector3 randomPosition = new Vector3(randomXPos, randomYPos, 0);

      Instantiate(pickupPrefab, randomPosition, pickupPrefab.transform.rotation);
    }

    // generate pickups on the right side of screen
    for (int i = 0; i < spawnAmount; i++)
    {
      // code to repeat

      float randomXPos = Random.Range(mainCamera.transform.position.x, topRightPosition.x);
      float randomYPos = Random.Range(bottomLeftPosition.y, topRightPosition.y);
      Vector3 randomPosition = new Vector3(randomXPos, randomYPos, 0);

      Instantiate(pickupPrefab, randomPosition, pickupPrefab.transform.rotation);
    }

    // generate a table
    for (int i = 0; i < columnAmount; i++)
    {
      // code to repeat
      // generate column
      for (int j = 0; j < rowAmount; j++)
      {
        // code to repeat

        float yPos = bottomLeftPosition.y + (i * 2f);
        float xPos = bottomLeftPosition.x + (j * 2f);
        Vector3 randomPosition = new Vector3(xPos, yPos, 0);

        Instantiate(pickupPrefab, randomPosition, pickupPrefab.transform.rotation);
      }
    }


    // generate a circle
    for (int i = 0; i < circlePoints; i++)
    {
      /* Distance around the circle */
      var radians = 2 * Mathf.PI / circlePoints * i;

      /* Get the vector direction */
      var vertical = Mathf.Sin(radians);
      var horizontal = Mathf.Cos(radians);

      var spawnDir = new Vector3(horizontal, vertical, 0);
      var spawnPos = originOfCircle.position + spawnDir * circleRadius;

      Instantiate(pickupPrefab, spawnPos, pickupPrefab.transform.rotation);
    }

    // // infinite loop
    // for (int i = 0; i < circlePoints; i--)
    // {

    // }

    // // infinite loop
    // while ( true )
    // {
    //     break;
    // }

    // // infinite loop
    // while( 5 < 10)
    // {

    // }

  }

  // Update is called once per frame
  void Update()
  {

  }
}
