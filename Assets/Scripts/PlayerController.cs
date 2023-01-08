using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed, rotationSpeed;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float vertivalInput = Input.GetAxisRaw("Vertical");

        Vector2 movemetnDirection = new Vector2(horizontalInput, vertivalInput);
        float inputMagnitude = Mathf.Clamp01(movemetnDirection.magnitude);
        movemetnDirection.Normalize();

        transform.Translate(movemetnDirection * moveSpeed * inputMagnitude * Time.deltaTime, Space.World);

        if(movemetnDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movemetnDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
