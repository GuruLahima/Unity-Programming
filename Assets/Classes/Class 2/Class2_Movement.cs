using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class2_Movement : MonoBehaviour
{
  public float movementSpeed;

  // Start is called before the first frame update
  void Start()
  {
    // example of modulo operator
    int x = 6;
    int y = 5;
    int z = y % x;
    Debug.Log("modulo of x % y = " + z);


    // example of ternary operator
    bool someCondition = false;
    int result = someCondition ? 1 : 0;
    Debug.Log("result of ternary operator = " + result);


  }


  // Update is called once per frame
  void Update()
  {
    // fetch the corners of the screen and save them in variables
    // top right corner is Screen.width, Screen.height
    Vector3 topRightPixel = new Vector3(Screen.width, Screen.height, 0);
    // bottom left corner is 0, 0
    Vector3 bottomLeftPixel = new Vector3(0, 0, 0);

    // convert the pixels to world coordinates so we can compare them to the position of the object
    Vector3 topRightCorner = Camera.main.ScreenToWorldPoint(topRightPixel);
    Vector3 bottomLeftCorner = Camera.main.ScreenToWorldPoint(bottomLeftPixel);

    // moving right
    // compare position of object to the right most position of the screen
    if (!((transform.position.x) > topRightCorner.x))
    {
      // get input from player
      if (Input.GetKey(KeyCode.D))
      {
        // we move in the X axis (left and right) by changing the X position of the object
        transform.Translate(movementSpeed * Time.deltaTime, 0, 0); // direct manipulation of position of object
      }
    }
    else
    {
      // teleport object to the left side of the screen when it reaches the right side
      transform.position = new Vector3(bottomLeftCorner.x, transform.position.y, 0);
    }

    // moving left
    // compare position of object to the left most position of the screen
    if (!((transform.position.x) < bottomLeftCorner.x))
    {
      // get input from player
      if (Input.GetKey(KeyCode.A))
      {
        // do something in this block
        transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
      }
    }
    else
    {
      // teleport object to the right side of the screen when it reaches the left edge
      transform.position = new Vector3(topRightCorner.x, transform.position.y, 0);
    }

    // moving up
    // compare position of object to the left most position of the screen
    if (!((transform.position.y) > topRightCorner.y))
    {
      // get input from player
      if (Input.GetKey(KeyCode.W))
      {
        // we move in the Y axis (up and down) by changing the Y position of the object
        transform.Translate(0, movementSpeed * Time.deltaTime, 0);
      }
    }
    else
    {
      // teleport object to the bottom side of the screen when it reaches the top edge
      transform.position = new Vector3(transform.position.x, bottomLeftCorner.y, 0);
    }

    // moving down
    // compare position of object to the left most position of the screen
    if (!((transform.position.y) < bottomLeftCorner.y))
    {
      // get input from player
      if (Input.GetKey(KeyCode.S))
      {
        // we move down by adding a minus sign before the movement speed
        transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
      }
    }
    else
    {
      // teleport object to the bottom side of the screen when it reaches the top edge
      transform.position = new Vector3(transform.position.x, topRightCorner.y, 0);
    }

  }
}
