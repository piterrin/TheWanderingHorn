using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComensal : MonoBehaviour {

    public GameObject comensal;
    public Transform spawn;
    public int orden;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //spawnea al comensal con un nombre de comensal
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            orden += 1;
            Instantiate(comensal, spawn.position, spawn.rotation).gameObject.name = ("Comensal");
        }
	}
}
