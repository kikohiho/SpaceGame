using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipcontroller : MonoBehaviour {


    public float speed;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
        transform.rotation = Quaternion.Euler(new Vector3(0, moveHorizontal, 0));

        rb.AddForce(movement * speed);

        
    }

    void Slowdown()
    {

    }
}
