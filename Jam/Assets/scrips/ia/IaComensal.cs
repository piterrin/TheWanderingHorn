using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IaComensal : MonoBehaviour {

    private NavMeshAgent MyNav;
    private SpawnComensal MySpawn;
    private GameManager MyGm;
    public int randomPoint;
    public GameObject mesa1,mesa2,mesa3,mesa4,mesa5,mesa6;
    public FoodValidator MyFoVa;

   // public bool point1, point2, point3, point4, point5, point6;

    // Use this for initialization
    private void Awake()
    {
        MyGm = GameObject.Find("GameManager").GetComponent<GameManager>();
        MySpawn = GameObject.Find("Spawn").GetComponent<SpawnComensal>();

        MyNav = GetComponent<NavMeshAgent>();
        // creo un random para que 
        randomPoint = Random.Range(0,6);

        //capturo el gameobject de mesa
        mesa1 = GameObject.Find("mesa1");
        mesa2 = GameObject.Find("mesa2");
        mesa3 = GameObject.Find("mesa3");
        mesa4 = GameObject.Find("mesa4");
        mesa5 = GameObject.Find("mesa5");
        mesa6 = GameObject.Find("mesa6");


        switch (randomPoint)
        {
            case 0:
                // comparo si en mi game manager es true
                if (!MyGm.chair1)
                {
                    //vuelvo el punto 1  true del game manager
                    MyGm.chair1 = true;
                    //llamo al metodo mesa1
                    Mesa1();   

                }
                // si el espacio esta lleno destrullo este gameobject
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                }
                    
                
            break;

            case 1:
                if (!MyGm.chait2)
                {
                    MyGm.chait2 = true;
                    Mesa2();

                }
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                }

                break;

            case 2:
                if (!MyGm.chair3)
                {
                    MyGm.chair3 = true;
                    Mesa3();

                }
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                }

                break;

            case 3:
                if (!MyGm.chair4)
                {   
                    MyGm.chair4 = true;
                    Mesa4();

                }
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                }

                break;

            case 4:
                if (!MyGm.chair5)
                {   
                    MyGm.chair5 = true;
                    Mesa5();


                }
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                }

                break;

            case 5:
                if (!MyGm.chair6)
                {  
                    MyGm.chair6 = true;
                    Mesa6();

                }
                else
                {
                    Debug.Log("me destruy");
                    Destroy(this.gameObject);
                    MySpawn.orden -= 1;
                }

                break;

        }

    }

    void Start () 
    {


		


	}
	
	// Update is called once per frame
	void Update () 
    {
       

       
	}



    //todo esto le dice al navmesh que valla a la mesa indicada
    public void Mesa1()
    {
        MyNav.SetDestination(mesa1.transform.position);


    }
    public void Mesa2()
    {
        MyNav.SetDestination(mesa2.transform.position);
    }
       
    public void Mesa3()
    {
        MyNav.SetDestination(mesa3.transform.position);
        
    }
    public void Mesa4()
    {
        MyNav.SetDestination(mesa4.transform.position);
        
    }
    public void Mesa5()
    {
        MyNav.SetDestination(mesa5.transform.position);
       
    }
    public void Mesa6()
    {
        MyNav.SetDestination(mesa6.transform.position);
        
    }

   


}
