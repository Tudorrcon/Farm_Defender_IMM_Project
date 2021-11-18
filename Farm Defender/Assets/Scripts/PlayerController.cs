using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 30.0f;
    private Rigidbody playerRb;
    private float upperZLimit = 10;
    private float lowerZLimit = 10;
    private float upperXLimit = -0.67f;
    private float lowerXLimit = -9.65f;

    public GameObject projectilePrefab;

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

        if(transform.position.z < lowerZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, lowerZLimit);
        }

        if(transform.position.z > upperZLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, upperZLimit);
        }

        if(transform.position.x < lowerXLimit)
        {
            transform.position = new Vector3(-lowerXLimit, transform.position.y, transform.position.z);
        }

        if(transform.position.z > upperXLimit)
        {
            transform.position = new Vector3(upperXLimit, transform.position.y, transform.position.z);
        }

        //if statement for shooting projectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
