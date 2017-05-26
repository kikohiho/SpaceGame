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
    }

    private void Turn()
    {
        // Rotar la nave en el eje y.
        turn = moveHorizontal * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0.0f, turn, 0.0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

}
