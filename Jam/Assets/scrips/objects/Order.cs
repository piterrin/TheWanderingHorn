using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Order",menuName = "Menu/Order")]
public class Order : ScriptableObject {

    [SerializeField]
    private OrderData.food food;
    [SerializeField]
    private int price;
    [SerializeField]
    private Sprite foodImage;


    public OrderData.food Food
    {
        get
        {
            return food;
        }

    }

    public int Price
    {
        get
        {
            return price;
        }

    }

    public Sprite FoodImage
    {
        get
        {
            return foodImage;
        }

    }
}
