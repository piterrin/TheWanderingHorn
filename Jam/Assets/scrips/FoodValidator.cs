using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodValidator : MonoBehaviour {

    // public GameObject Comensal;
    public GameObject comensal;
    public IaComensal MyIa;
    public FoodController MyFoCo;
    public FoodSelector MyFoSe;
    public GameManager MyGm;
 

	// Use this for initialization
	void Start () {

        comensal = GameObject.Find("Comensal");
        MyIa = GameObject.Find("Comensal").GetComponent<IaComensal>();
        MyFoCo = GameObject.Find("Player").GetComponent<FoodController>();
        MyFoSe = GameObject.Find("Comensal" ).GetComponent<FoodSelector>();
        MyGm = GameObject.Find("GameManager").GetComponent<GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(MyFoCo.tipeFood);
        Debug.Log(MyFoSe.requestFood);

	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Comensal"))
        {
            Validacion();
         
        }
    }


    public void Validacion ()
    {
        if (MyFoCo.tipeFood == MyFoSe.requestFood)
        {
            
            MyGm.puntos += 100;

            switch (MyIa.randomPoint)
            {
                case 0:
                    // comparo si en mi game manager es true para saber su hay alguien sentado
                    if (MyGm.chair1)
                    {
                        //vuelvo el punto 1  true del game manager
                        MyGm.chair1 = false;
                        //desocupo el player del plato

                        MyFoCo.tipeFood = 0;




                        //destruyo el comensal y el plato
                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);

                    }


                    break;

                case 1:
                    if (MyGm.chait2)
                    {
                        MyGm.chait2 = false;

                        MyFoCo.tipeFood = 0;

                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);
                    }

                    break;

                case 2:
                    if (MyGm.chair3)
                    {
                        MyGm.chair3 = false;

                        MyFoCo.tipeFood = 0;

                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);

                    }
                  

                    break;

                case 3:
                    if (MyGm.chair4)
                    {
                        MyGm.chair4 = false; 

                        MyFoCo.tipeFood = 0;

                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);
                    }

                    break;

                case 4:
                    if (MyGm.chair5)
                    {
                        MyGm.chair5 = false;

                        MyFoCo.tipeFood = 0;

                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);
                    
                    }
                   

                    break;

                case 5:
                    if (MyGm.chair6)
                    {
                        MyGm.chair6 = false;

                        MyFoCo.tipeFood = 0;

                        Destroy(comensal.gameObject);
                        Destroy(this.gameObject);
                      
                    }

                    break;

            }

        }
    }


}
