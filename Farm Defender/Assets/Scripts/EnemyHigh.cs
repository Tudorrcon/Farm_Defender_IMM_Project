using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHigh : MonoBehaviour
{ 
    public int health = 2;
    public float speed;
    private int pointValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}