using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
    Rigidbody2D body;

    public float horizontal;
    public float vertical;
    public float speed; 

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent <Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(-7.4f, 5.76f, 6f);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


    }
    // Fixed update is called 50 times per second
	private void FixedUpdate()
	{
		body.velocity = new Vector2(horizontal * speed, vertical * speed);

	}
}
