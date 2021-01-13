using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Never set the value of a PUBLIC variable here; the inspector will override it without tellign you
    // If you need to, set it in Start() instead
    public float playerSpeed; // 'float' is short for floating point number, which is basically just a normal number
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player speed: " + playerSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Vertical: " + Input.GetAxis("Vertical"));
        Debug.Log("Horizontal: " + Input.GetAxis("Horizontal"));

        // WASD to move
        // Find the new position we'll move to
        float maxDistanceToMove = playerSpeed * Time.deltaTime;
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // directional input
        Vector3 movementVector = inputVector * maxDistanceToMove; // how far we will move
        Vector3 newPosition = transform.position + movementVector; // position we are moving to

        // Look at new position, then move there
        transform.LookAt(newPosition);
        transform.position = newPosition;

        // If you want WASD to scale instead of change position for some reason lol (toggle ot change size to solve puzzles or something...?)
        //transform.localScale += Vector3.one * Input.GetAxis("Vertical") * maxDistanceToMove;
        //transform.localScale += Vector3.right * Input.GetAxis("Horizontal") * maxDistanceToMove;

        // Click to fire (GetButton for hold, GetButtonDown for semi automatic)
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);
        }
    }
}
