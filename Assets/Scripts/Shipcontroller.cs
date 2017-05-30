using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipcontroller : MonoBehaviour {

    // Puse esta parte comentado por si las moscas
    /*
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
        Quaternion rotation = Quaternion.Euler(new Vector3(0, moveHorizontal, 0));

        rb.AddForce(movement * speed);

        
    }*/
    

    public float speed;
    public float turnSpeed;
    public float tilt;
    // Tilt se usara eventualmente para que la nave haga un roll.

    private float moveHorizontal;
    private float moveVertical;
    private float turn;

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Move();
        Turn();
    }

    // La idea para las funciones Move y Turn lo saque
    // del Tank tutorial de Unity
    private void Move()
    {
        // Movimiento hacia al frente de la nave
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * speed);
        else if (Input.GetKey(KeyCode.S))
            rb.AddForce(-transform.forward * speed);
    }

    private void Turn()
    {
        // Rotar la nave en el eje y.
        //  turn = moveHorizontal * turnSpeed * Time.deltaTime;
        ////  Vector3 euler = transform.localEulerAngles;
        //  //euler.z = Mathf.Lerp(euler.z, moveHorizontal, 2.0f * Time.deltaTime);
        //  //transform.localEulerAngles = euler;
        //  Quaternion turnRotation = Quaternion.Euler(0.0f, turn, 0.0f);
        //  rb.MoveRotation(rb.rotation * turnRotation);
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(transform.up * moveHorizontal);
        } else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.up * moveHorizontal);
        }
        
    }

}
