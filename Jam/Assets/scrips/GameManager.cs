using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //bools para saber en que silla estoy
    public bool chair1, chait2, chair3, chair4, chair5, chair6;
    public int puntos;
    public Text Score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // nuestro el puntage en pantalla
        Debug.Log(puntos);

        Score.text = "Puntos"+ " " + puntos.ToString();
		
	}
}
