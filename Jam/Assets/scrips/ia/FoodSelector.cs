using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSelector : MonoBehaviour
{

    public int requestFood, imageController;
    public string comida;
    public Image seleccion, polloImg, carneImg, cervezaImg;

    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(comida);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Meta"))
        {
            Debug.Log("llegue quiero " + " " + comida);
            seleccion.enabled = true;

            switch (imageController)
            {
                case 1:
                    polloImg.enabled = true;
                    break;
                case 2:
                    carneImg.enabled = true;
                    break;
                case 3:
                    cervezaImg.enabled = true;
                    break;

            }
        }
    }



}
