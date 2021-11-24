using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    
    private Rigidbody playerRb;
    public float speed = 10.0f;

    private float ZLimit = 8.5f;
    private float XLimit = 15.7f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);


        



        if(transform.position.z < -ZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -ZLimit);
        }

        if(transform.position.z > ZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZLimit);
        }

        if(transform.position.x < -XLimit)
        {
            transform.position = new Vector3(-XLimit, transform.position.y, transform.position.z);
        }

        if(transform.position.x > XLimit)
        {
            transform.position = new Vector3(XLimit, transform.position.y, transform.position.z);
        }


    }
}
