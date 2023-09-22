using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAxisVisualizer : MonoBehaviour
{
  public string axisName = "Horizontal";

  // we use these references to represent the axis in the scene. purely for debugging purposes
  public Transform axisMin;
  public Transform axisMax;
  public Transform axisCenter;
  public Transform currentAxisValue;

  private void Start()
  {
    axisCenter.position = new Vector3(
      axisMin.position.x + ((axisMax.position.x - axisMin.position.x) / 2),
      axisMin.position.y,
      axisMin.position.z);
  }

  // Update is called once per frame
  void Update()
  {
    float centerOfAxis = axisMin.position.x + ((axisMax.position.x - axisMin.position.x) / 2);

    currentAxisValue.position = new Vector3(
      centerOfAxis + (Input.GetAxis(axisName) * (axisMax.position.x - axisMin.position.x) / 2),
      axisMin.position.y,
      axisMin.position.z);
  }
}
