using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1_Movement : MonoBehaviour
{
  // we declare this variable as public so we can change it in the inspector
  // don't forget to give it value in the inspector
  public float movementSpeed = 1f;

  // Update is called once per frame
  void Update()
  {
    // it's always good to debug
    Debug.Log("delta time = " + Time.deltaTime);

    // move right
    // get input from player
    if (Input.GetKey(KeyCode.D))
    {
      // with the following line we directly manipule the position of this object
      transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
    }

    // move left
    // get input from player
    if (Input.GetKey(KeyCode.A))
    {
      transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
    }

    // move up
    // get input from player
    if (Input.GetKey(KeyCode.W))
    {
      transform.Translate(0, movementSpeed * Time.deltaTime, 0);
    }

    // move down
    // get input from player
    if (Input.GetKey(KeyCode.S))
    {
      transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
    }
  }
}
