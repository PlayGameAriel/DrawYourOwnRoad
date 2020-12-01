using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class Destroy : MonoBehaviour
{
    
    [SerializeField] string triggeringTag;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody rb=gameObject.GetComponent<Rigidbody>();

        if (other.tag == triggeringTag )
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;

        }
    }
}