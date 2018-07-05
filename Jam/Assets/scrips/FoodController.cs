using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {


    public int tipeFood;
    public GameObject comiPrefab1, comiPrefab2, comiPrefab3;
    public Transform spawnPlato;
    public PlatoController MyPlato;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      
	}





    private void OnTriggerEnter(Collider other)
    {
        // compruebo si tiene algo en la mano
        if (tipeFood == 0)
        {
            if (other.gameObject.name == "collisionfood1")
            {
                Debug.Log("soy1");
                tipeFood = 1;
                Debug.Log(tipeFood);
                Instantiate(comiPrefab1, spawnPlato.position, spawnPlato.rotation,spawnPlato);
            }
            if (other.gameObject.name == "collisionfood2")
            {
                Debug.Log("soy2");
                tipeFood = 2;
                Debug.Log(tipeFood);
                Instantiate(comiPrefab2, spawnPlato.position, spawnPlato.rotation,spawnPlato);
            }
            if (other.gameObject.name == "collisionfood3")
            {
                Debug.Log("soy3");
                tipeFood = 3;
                Debug.Log(tipeFood);
                Instantiate(comiPrefab3, spawnPlato.position, spawnPlato.rotation,spawnPlato);
            }
        }
        //si es cierto que tiene algo lo puedo botar
        if (other.gameObject.name == "Trash")
        {
            tipeFood = 0;
            Debug.Log(tipeFood);
            MyPlato.Destruir();
        }
    }
}
