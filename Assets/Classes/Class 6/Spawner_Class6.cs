using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Class6 : MonoBehaviour
{
  public GameObject pickupPrefab;
  public int spawnAmount = 10;
  public Camera mainCamera;
  private GameObject myGameObject;

  // we multiply the scale of each pickup by this amount when we increase difficulty
  public float difficultyScaleFactor = 0.9f;


  // GameObject[] pickups;
  public static List<GameObject> pickups = new List<GameObject>();
  public static List<GameObject> collectedPickups = new List<GameObject>();


  // Start is called before the first frame update
  void Start()
  {

    pickups.Clear();

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

      // populating the array with game objects	
      // pickups[i] = Instantiate(pickupPrefab, randomPosition, pickupPrefab.transform.rotation);
      GameObject newPickup = Instantiate(pickupPrefab, randomPosition, pickupPrefab.transform.rotation);
      pickups.Add(newPickup);
    }

  }


  [ContextMenu("Increase Difficulty")]
  void IncreaseDifficulty()
  {
    // version 1
    // for (int i = 0; i < pickups.Count; i++)
    // {

    //   // null check
    //   pickups[i].transform.localScale *= scale;
    // }

    // version 2
    foreach (GameObject item in pickups)
    {
      item.transform.localScale *= difficultyScaleFactor;
    }

    // version 3
    // pickups.ForEach((item) =>
    // {
    //   item.transform.localScale *= scale;
    // });
  }


}
