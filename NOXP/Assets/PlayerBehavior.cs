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
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // directional input
        Rigidbody ourRigidbody = GetComponent<Rigidbody>();
        ourRigidbody.velocity = inputVector * playerSpeed;

        // Look toward new position
        Vector3 lookAtPosition = transform.position + inputVector;
        transform.LookAt(lookAtPosition);

        // Click to fire (GetButton for hold, GetButtonDown for semi automatic)
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);
        }
    }
}
