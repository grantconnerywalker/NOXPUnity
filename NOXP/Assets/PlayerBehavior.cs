using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    //static readonly float playerSpeed = 10;
    //static readonly float maxDistanceToMove = playerSpeed * Time.deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Vertical: " + Input.GetAxis("Vertical"));
        Debug.Log("Horizontal: " + Input.GetAxis("Horizontal"));

        float playerSpeed = 10;
        float maxDistanceToMove = playerSpeed * Time.deltaTime;

        transform.position += Vector3.forward * Input.GetAxis("Vertical") * maxDistanceToMove;
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * maxDistanceToMove;

        // If you want WASD to scale instead of change position for some reason lol
        //transform.localScale += Vector3.one * Input.GetAxis("Vertical") * maxDistanceToMove;
        //transform.localScale += Vector3.right * Input.GetAxis("Horizontal") * maxDistanceToMove;
    }
}
