using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Transform orientation;
    public float speed;


	Vector3 direction;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        direction = orientation.forward * Input.GetAxis("Vertical") + orientation.right * Input.GetAxis("Horizontal");

    }

	private void FixedUpdate()
	{
		rb.AddForce(direction * speed, ForceMode.Force);
	}
}
