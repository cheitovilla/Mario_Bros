using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public Text contadortext;
    public Text wintext;
    public Transform player;
    private int punt1;
   


	// Use this for initialization
	void Start () {
        punt1 = 0;
		
	}
	
    public void Puntajee1()
    {
        punt1 = punt1 + 1;
        contadortext.text = punt1.ToString();
        //if (punt1>=10)
        //{
        //    wintext.text = "You Win!";
        //}
    } 
	// Update is called once per frame
	void Update () {
		
	}
}
