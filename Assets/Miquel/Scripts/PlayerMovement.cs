using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float sprintMultiplier = 2.0f;
    private float yaw, pitch;
    public float SpeedH, SpeedV = 1;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Cuando queramos que haya deslizamiento, cambiamos esta variable
        // rb.drag = 0;
    }

    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xMovement, 0.0f, zMovement) * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement *= sprintMultiplier;
        }

        transform.Translate(movement);

        yaw += SpeedH * Input.GetAxis("Mouse X");
        pitch += SpeedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(-pitch, yaw, 0f);

    }
}
