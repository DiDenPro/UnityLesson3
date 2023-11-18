using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb = new Rigidbody();
    [SerializeField] float speed = 5f;
    [SerializeField] int jumps = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumps>0)
        {
            rb.velocity = new Vector3(rb.velocity.x,0,rb.velocity.z);
            rb.AddForce(Vector3.up*speed, ForceMode.Impulse);
            jumps--;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "floor")
        {
            jumps = 2;
        }
    }
}
