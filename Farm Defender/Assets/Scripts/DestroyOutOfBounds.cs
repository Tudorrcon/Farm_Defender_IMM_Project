using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float bottomLimit = -9.7f;
    private float lateralLimit = 15.6f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -lateralLimit || transform.position.x > lateralLimit)
        {
            Destroy(gameObject);
        }
    }
}
