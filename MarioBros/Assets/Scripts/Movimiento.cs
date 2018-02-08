using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float velX = 0.1f;
    public float movX;
    public float inputX;

    public float salto = 100;
	public Transform pie;
    public float radiopie;
    public LayerMask suelo;
    public bool ensuelo;

    Animator animator;

    void Awake(){
       animator = GetComponent <Animator>();
    }
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

        if (inputX !=0){
            animator.SetFloat ("velX",1);
            }
            else {
            animator.SetFloat ("velX",0);
            }
        

        ensuelo = Physics2D.OverlapCircle (pie.position, radiopie, suelo);
        //Debug.Log (ensuelo);

        if (ensuelo == true && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce (new Vector2(0, salto));
        }
	}
}
