using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Class4 : MonoBehaviour
{
  public GameObject pickupPrefab;
  public int spawnAmount = 10;
  public Camera mainCamera;
  private GameObject myGameObject;


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

  }



}
