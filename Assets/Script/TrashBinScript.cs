using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinScript : MonoBehaviour
{
	float speed = 10f;
	public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		KeyboardInput();
        
    }

    void KeyboardInput()
	{

        if(Input.GetKey(KeyCode.LeftArrow))
		{
			if (transform.position.x > -6)
			{
				rb = GetComponent<Rigidbody>();
				rb.MovePosition(transform.position - transform.right * Time.deltaTime * speed);
			}
			
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (transform.position.x < 8)
			{
				rb = GetComponent<Rigidbody>();
				rb.MovePosition(transform.position + transform.right * Time.deltaTime * speed);
			}
		}
	}
}
