using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLow : MonoBehaviour
{
    private Rigidbody enemyLowRb;
    public int health = 1;
    public float speed;

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
