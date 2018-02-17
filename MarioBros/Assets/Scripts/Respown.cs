using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respown : MonoBehaviour {


    public GameObject player;
  //  public Transform respown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y < -7)
        {
            player.transform.position = new Vector3(-5.92f, -4.403f);
        }
    }


    
       
    
}
