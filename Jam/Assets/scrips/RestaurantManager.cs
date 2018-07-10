using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantManager : MonoBehaviour {

    public static RestaurantManager instance = null;

    [SerializeField]
    private List<Order> foods;


    private void Awake()
    {
        instance = this;
    }

    public Order GetOrder ()
    {
        int index = Random.Range(0, foods.Count);
        return foods[index];
    }

}
