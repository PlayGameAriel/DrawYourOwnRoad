using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class Move2 : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10f;
  
    

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        Vector3 movementVector = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
        transform.rotation = Quaternion.Euler(0, 90, 0);

     

    }
}