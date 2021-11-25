using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private float speed = 20.0f;
    private PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.hasPowerup == true)
        {
            speed = 60.0f;
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z > 11)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyLowTag"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("EnemyHighTag"))
        {
            EnemyHigh scriptEnemy = other.gameObject.GetComponent<EnemyHigh>();
            scriptEnemy.health--;
            if (scriptEnemy.health == 0)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
