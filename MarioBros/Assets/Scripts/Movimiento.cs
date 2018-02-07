using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float velX = 0.1f;
    public float movX;
    public float inputX;
    public float salto = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float inputX = Input.GetAxis("Horizontal");

        if (inputX>0)
        {
            movX = transform.position.x + (inputX*velX);
            transform.position = new Vector3 (movX, transform.position.y, 0);
            transform.localScale = new Vector3 (1, 1, 1);
        }

        if (inputX<0)
        {
            movX = transform.position.x + (inputX * velX);
            transform.position = new Vector3 (movX, transform.position.y, 0);
            transform.localScale = new Vector3 (-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce (new Vector2(0, salto));
        }
	}
}
