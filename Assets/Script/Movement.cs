using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Movement : MonoBehaviour
{

    public Transform cameraTransform;
    public float speed;
    


	private Vector3 direction;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Fångar input från användaren
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Beräknar riktningen baserat på kamerans orientering
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Tar bort Y-komponenten för att undvika rörelse i vertikal riktning
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        // Beräknar rörelseriktningen
        direction = (forward * verticalInput + right * horizontalInput).normalized;
    }

    private void FixedUpdate()
    {
        // Applicerar kraft för att flytta rigidbody
        rb.AddForce(direction * speed, ForceMode.Force);
    }


}
