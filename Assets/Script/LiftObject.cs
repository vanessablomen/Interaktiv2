using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftObject : MonoBehaviour
{
    public Transform gripPoint;

    Rigidbody rb;
    private Transform carried;
	public Transform cam;
	public LayerMask lm;
    RaycastHit hit;

	public float throwForce = 10f;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (Physics.Raycast(cam.position, cam.forward, out hit, 2, lm))
            {
                carried = hit.transform;
				rb = carried.GetComponent<Rigidbody>();
			}
        }
        if (Input.GetKeyUp(KeyCode.G) && carried != null)
        {
            rb.AddForce(cam.forward * throwForce, ForceMode.Impulse);
            carried = null;
        }

		if (carried != null)
        {
			carried.position = gripPoint.position;
            rb.velocity = Vector3.zero;
		}

	}
}
