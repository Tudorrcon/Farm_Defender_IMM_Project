using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLow : MonoBehaviour
{

    public float speed = 10;
    private Rigidbody enemyLowRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyLowRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
