using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "floor")
        {
            Debug.Log("Floor");
        }
        if (collision.transform.tag == "sphere")
        {
            Debug.Log("Sphere");
        }
        if (collision.transform.tag == "capsule")
        {
            Debug.Log("Capsule");
        }
        if (collision.transform.tag == "cylinder")
        {
            Debug.Log("Cylinder");
        }
    }
}
