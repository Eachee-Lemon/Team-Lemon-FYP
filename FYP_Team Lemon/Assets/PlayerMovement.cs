using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Adjust speed as needed
    public float sensitivity = 2f; // Mouse look sensitivity

    private float rotationX = 0f;

    // Update is called once per frame

    void Update()
    {
        // Player Movement
        PlayerMovementInput();

        // Player Look
        PlayerLookInput();
    }

    void PlayerMovementInput()
    {
        // Get user input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Apply movement to the player's position
        transform.Translate(movement);
    }

    void PlayerLookInput()
    {
        // Get mouse input for looking around
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the player horizontally based on mouse movement
        transform.Rotate(Vector3.up * mouseX);

        // Calculate vertical rotation for looking up and down
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Clamp rotation to prevent flipping

        // Apply vertical rotation to the camera
        //Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
