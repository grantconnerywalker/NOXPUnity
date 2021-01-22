using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public GameObject player;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody ourRigidbody = GetComponent<Rigidbody>();
        Vector3 vectorToPlayer = player.transform.position - transform.position; // destination - origin
        ourRigidbody.velocity = vectorToPlayer.normalized * enemySpeed;
    }
}
