using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatoController : MonoBehaviour {

    public FoodController MyFoCo;
   

	// Use this for initialization
	void Start () {
        MyFoCo = GameObject.Find("Player").GetComponent<FoodController>();
        MyFoCo.MyPlato = this.GetComponent<PlatoController>();
	}
	
	// Update is called once per frame
	void Update () {
      

	}


    public void Destruir ()
    {
        //destrulle este objeto
        Destroy(this.gameObject);
    }
}
