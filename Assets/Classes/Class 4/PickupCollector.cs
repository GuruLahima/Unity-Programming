using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PickupCollector : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision)
  {
    /// Debug.Log("<color=green> The thing we hit is called </color>" + collision.gameObject.name);

    // destroy the pickup
    // Destroy(collision.gameObject);

    // add points

    // trigger pickup effect
    // transform.localScale *= 2;

  }

  private void OnCollisionExit2D(Collision2D collision)
  {
    // Debug.Log("<color=red>The thing we escaped is called </color>" + collision.gameObject.name);

  }

  private void OnCollisionStay2D(Collision2D collision)
  {
    // Debug.Log("<color=yellow>The thing we are touching is called </color>" + collision.gameObject.name);

  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    Debug.Log("<color=green> The thing we hit is called </color>" + collision.gameObject.name);
    // destroy the pickup
    Destroy(collision.gameObject);

    // add points

    // trigger pickup effect
    // transform.localScale *= 2;

  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    Debug.Log("<color=red>The thing we escaped is called </color>" + collision.gameObject.name);

  }

  private void OnTriggerStay2D(Collider2D collision)
  {
    Debug.Log("<color=yellow>The thing we are touching is called </color>" + collision.gameObject.name);

  }


}
