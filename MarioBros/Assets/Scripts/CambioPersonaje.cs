using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPersonaje : MonoBehaviour {

   
    public GameObject player1;
    public GameObject player2;
    public bool canchange = true;
	// Use this for initialization
	void Start () {
		
	}
	

    void OnTriggerEnter2D(Collider2D col)
    {
        if (player1.activeSelf == true)
        {
            Debug.Log("Hola");
            player2.transform.position = player1.transform.position;
            player1.SetActive(false);
            player2.SetActive(true);
            canchange = false;
        }

       else if (player2.activeSelf == true)
        {
            Debug.Log("Hola");
            player1.transform.position = player2.transform.position;
            player2.SetActive(false);
            player1.SetActive(true);
            canchange = true;
        }

    }

	// Update is called once per frame
	void Update () {
        //if (player1.transform.position.x>10 && canchange)
        //{
        //    player2.transform.position = player1.transform.position;
        //    player1.SetActive(false);
        //    player2.SetActive(true);
        //    canchange = false;
        //}
        //if (!canchange && player2.transform.position.x < 10)
        //{
        //    player1.transform.position = player2.transform.position;
        //    player2.SetActive(false);
        //    player1.SetActive(true);
        //    canchange = true;
        //}

    }
}
