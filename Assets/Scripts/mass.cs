// Expose mass to allow adjustment from
// the inspector.

using UnityEngine;
using System.Collections;

public class mass : MonoBehaviour
{
    static public float mas;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mas++;
    }

// Update is called once per frame
void Update()
    {
        
    }
}
